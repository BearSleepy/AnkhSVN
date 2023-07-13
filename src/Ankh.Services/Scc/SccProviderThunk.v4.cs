using System;
using System.Threading;

using Ankh.VS;

using Microsoft.VisualStudio.Imaging.Interop;
using Microsoft.VisualStudio.Shell;
using Microsoft.VisualStudio.Shell.Interop;

namespace Ankh.Scc
{
	using Task = System.Threading.Tasks.Task;

	partial class SccProviderThunk : IVsSccChanges, IVsSccChangesDisplayInformation, IVsSccCurrentBranch,
		IVsSccCurrentBranchDisplayInformation, IVsSccCurrentRepository, IVsSccCurrentRepositoryDisplayInformation
		/*, IVsSccUnpublishedCommits, IVsSccUnpublishedCommitsDisplayInformation*/
#if VS_14_ENV
		, IVsSccPublish, IVsSccSolution
#endif // VS_15_ENV
	{
		string IVsSccCurrentBranchDisplayInformation.BranchDetail
		{
			get
			{
				return BranchDetail;
			}
		}

		ImageMoniker IVsSccCurrentBranchDisplayInformation.BranchIcon
		{
			get
			{
				ImageReference r = BranchIcon;
				return new ImageMoniker()
				{
					Guid = r.Guid,
					Id = r.Id
				};
			}
		}

		string IVsSccCurrentBranchDisplayInformation.BranchName
		{
			get
			{
				return BranchName;
			}
		}

		int IVsSccChangesDisplayInformation.PendingChangeCount
		{
			get
			{
				return PendingChangeCount;
			}
		}

		string IVsSccChangesDisplayInformation.PendingChangeDetail
		{
			get
			{
				return PendingChangeDetail;
			}
		}

		string IVsSccChangesDisplayInformation.PendingChangeLabel
		{
			get
			{
				return PendingChangeLabel;
			}
		}

		string IVsSccCurrentRepositoryDisplayInformation.RepositoryDetail
		{
			get { return RepositoryDetail; }
		}

		ImageMoniker IVsSccCurrentRepositoryDisplayInformation.RepositoryIcon
		{
			get
			{
				ImageReference r = RepositoryIcon;
				return new ImageMoniker()
				{
					Guid = r.Guid,
					Id = r.Id
				};
			}
		}

		string IVsSccCurrentRepositoryDisplayInformation.RepositoryName
		{
			get
			{
				return RepositoryName;
			}
		}

		/*int IVsSccUnpublishedCommitsDisplayInformation.UnpublishedCommitCount
		{
			get
			{
				return UnpublishedCommitCount;
			}
		}

		string IVsSccUnpublishedCommitsDisplayInformation.UnpublishedCommitDetail
		{
			get
			{
				return UnpublishedCommitDetail;
			}
		}

		string IVsSccUnpublishedCommitsDisplayInformation.UnpublishedCommitLabel
		{
			get
			{
				return UnpublishedCommitLabel;
			}
		}

		event EventHandler IVsSccUnpublishedCommits.AdvertisePublish
		{
			add { AdvertisePublish += value; }
			remove { AdvertisePublish -= value; }
		}*/

		#region Threading
		partial void CreateDummyTask(ref object task)
		{
			task = new Task(DummyTask);
		}
		void DummyTask()
		{

		}
		protected Task RunAsyncOnMainThread(SccAction action)
		{
			return (Task)RunTaskOnMainThread(action);
		}
		#endregion Threading

		#region Publish Workflow
#if VS_14_ENV
		public event EventHandler AddedToSourceControl;

		public string GetSolutionFileName()
        {
            var sol = GetService(typeof(SVsSolution)) as IVsSolution;
			if (sol == null)
				return null;

            string directory, file, userOptionsFile;
            if (sol.GetSolutionInfo(out directory, out file, out userOptionsFile) == VSErr.S_OK)
            {
                return file;
            }

            return null;
        }
		
		public bool IsSolutionLoaded()
        {
			return  GetSolutionFileName() != null;
        }

		void PublishWorkflow()
		{
			if (!IsSolutionLoaded())
				return;	// this should never happen, as long as button only shows when a solution exists

			//TODO: add actual publish here
			//  the only reason this is here at all is to allow show up in publish button list.
			//  some users using this button to 

			// Raise the event to inform the shell that the solution was added to Source Control
			AddedToSourceControl?.Invoke(this, EventArgs.Empty);
		}

		internal async Task RunAsyncOnMainThread(SccAction action, CancellationToken cancellationToken)
		{
			cancellationToken.ThrowIfCancellationRequested();
			await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

			action();
		}

		async Task IVsSccPublish.BeginPublishWorkflowAsync(CancellationToken cancellationToken)
		{
			await RunAsyncOnMainThread(PublishWorkflow, cancellationToken);
			//cancellationToken.ThrowIfCancellationRequested();
   //         await ThreadHelper.JoinableTaskFactory.SwitchToMainThreadAsync();

			//PublishWorkflow();
		}
#endif // VS_14_ENV
		#endregion Publish Workflow

#if AS_BUILD_REPLACED
		public event EventHandler AddedToSourceControl;

		protected Task RunAsyncOnMainThread(SccAction action)
		{
			return (Task)RunTaskOnMainThread(action);
		}

		partial void CreateDummyTask(ref object task)
		{
			task = new Task(delegate { });
		}

		System.Threading.Tasks.Task IVsSccPublish.BeginPublishWorkflowAsync(CancellationToken cancellationToken)
		{
			return RunAsyncOnMainThread(OnPublishWorkflow);
		}

#endif // AS_BUILD_REPLACED

		System.Drawing.Point GetPoint(ISccUIClickedEventArgs args)
		{
			System.Windows.Point p = args.ClickedElementPosition.TopRight;
			return new System.Drawing.Point((int)p.X, (int)p.Y);
		}

		System.Threading.Tasks.Task IVsSccCurrentBranch.BranchUIClickedAsync(ISccUIClickedEventArgs args, CancellationToken cancellationToken)
		{
			return RunAsyncOnMainThread(delegate { OnBranchUIClicked(GetPoint(args)); });
		}

		System.Threading.Tasks.Task IVsSccChanges.PendingChangesUIClickedAsync(ISccUIClickedEventArgs args, CancellationToken cancellationToken)
		{
			return RunAsyncOnMainThread(delegate { OnPendingChangesClicked(GetPoint(args)); });
		}

		System.Threading.Tasks.Task IVsSccCurrentRepository.RepositoryUIClickedAsync(ISccUIClickedEventArgs args, CancellationToken cancellationToken)
		{
			return RunAsyncOnMainThread(delegate { OnRepositoryUIClicked(GetPoint(args)); });
		}

		//System.Threading.Tasks.Task IVsSccUnpublishedCommits.UnpublishedCommitsUIClickedAsync(ISccUIClickedEventArgs args, CancellationToken cancellationToken)
		//{
		//    return RunAsyncOnMainThread(delegate { OnUnpublishedCommitsUIClickedAsync(GetPoint(args)); });
		//}
	}
}
