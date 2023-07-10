// Copyright 2008-2009 The AnkhSVN Project
//
//  Licensed under the Apache License, Version 2.0 (the "License");
//  you may not use this file except in compliance with the License.
//  You may obtain a copy of the License at
//
//    http://www.apache.org/licenses/LICENSE-2.0
//
//  Unless required by applicable law or agreed to in writing, software
//  distributed under the License is distributed on an "AS IS" BASIS,
//  WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//  See the License for the specific language governing permissions and
//  limitations under the License.

using System;

using Ankh.UI.WizardFramework;

namespace Ankh.UI.MergeWizard
{
	public partial class MergeSummaryPage : BaseWizardPage
	{
		public MergeSummaryPage()
		{
			IsPageComplete = true;

			Text = ResourcesMerge.MergeSummaryPageHeaderTitle;
			this.Description = ResourcesMerge.MergeSummaryPageHeaderMessage;
			InitializeComponent();
		}

		private void WizardDialog_PageChangeEvent(object sender, EventArgs e)
		{
			if (Wizard.CurrentPage == this)
			{
				Message = null;

				PopulateUI();
			}
		}

		private void PopulateUI()
		{
			if (!DesignMode)
			{
				MergeWizard.MergeType mergeType = Wizard.GetPage<MergeTypePage>().SelectedMergeType;
				MergeOptionsPage mergeOptions = Wizard.GetPage<MergeOptionsPage>();

				// Populate Merge Target
				mergeTargetTextBox.Text = Wizard.MergeTarget.FullPath;
				// Populate Merge Source 1
				if (mergeType == MergeWizard.MergeType.TwoDifferentTrees)
					mergeSource1TextBox.Text = Wizard.GetPage<MergeSourceTwoDifferentTreesPage>().MergeSourceOne;
				else
					mergeSource1TextBox.Text = Wizard.MergeSource.Target.ToString();

				// Populate Merge Source 2
				if (mergeType == MergeWizard.MergeType.TwoDifferentTrees)
					if (Wizard.GetPage<MergeSourceTwoDifferentTreesPage>().HasSecondMergeSourceUrl)
						mergeSource2TextBox.Text = Wizard.GetPage<MergeSourceTwoDifferentTreesPage>().MergeSourceTwo;
					else
						mergeSource2TextBox.Text = Wizard.GetPage<MergeSourceTwoDifferentTreesPage>().MergeSourceOne;
				else
					mergeSource2TextBox.Text = ResourcesMerge.NotApplicableShort;

				// Populate Revisions
				if (mergeType == MergeWizard.MergeType.TwoDifferentTrees)
				{
					MergeSourceTwoDifferentTreesPage tdtPage = Wizard.GetPage<MergeSourceTwoDifferentTreesPage>();

					revisionsTextBox.Text = (tdtPage.MergeFromRevision != -1 ? tdtPage.MergeFromRevision.ToString() : ResourcesMerge.HEAD) + "-" +
						(tdtPage.MergeToRevision != -1 ? tdtPage.MergeToRevision.ToString() : ResourcesMerge.HEAD);
				}
				else
					if (Wizard.MergeRevisions == null)
						revisionsTextBox.Text = ResourcesMerge.All;
					else
						revisionsTextBox.Text = MergeWizard.MergeRevisionsAsString(Wizard.MergeRevisions);

				// Populate Binary Conflicts
				if (mergeOptions.BinaryConflictResolution == MergeOptionsPage.ConflictResolutionOption.MARK)
					binaryConflictsTextBox.Text = ResourcesMerge.ConflictHandlingMark;
				else if (mergeOptions.BinaryConflictResolution == MergeOptionsPage.ConflictResolutionOption.MINE)
					binaryConflictsTextBox.Text = ResourcesMerge.ConflictHandlingMine;
				else if (mergeOptions.BinaryConflictResolution == MergeOptionsPage.ConflictResolutionOption.PROMPT)
					binaryConflictsTextBox.Text = ResourcesMerge.ConflictHandlingPrompt;
				else if (mergeOptions.BinaryConflictResolution == MergeOptionsPage.ConflictResolutionOption.THEIRS)
					binaryConflictsTextBox.Text = ResourcesMerge.ConflictHandlingTheirs;
				else if (mergeOptions.BinaryConflictResolution == MergeOptionsPage.ConflictResolutionOption.BASE)
					binaryConflictsTextBox.Text = ResourcesMerge.ConflictHandlingBase;

				// Populate Text Conflicts
				if (mergeOptions.TextConflictResolution == MergeOptionsPage.ConflictResolutionOption.MARK)
					textConflictsTextBox.Text = ResourcesMerge.ConflictHandlingMark;
				else if (mergeOptions.TextConflictResolution == MergeOptionsPage.ConflictResolutionOption.MINE)
					textConflictsTextBox.Text = ResourcesMerge.ConflictHandlingMine;
				else if (mergeOptions.TextConflictResolution == MergeOptionsPage.ConflictResolutionOption.PROMPT)
					textConflictsTextBox.Text = ResourcesMerge.ConflictHandlingPrompt;
				else if (mergeOptions.TextConflictResolution == MergeOptionsPage.ConflictResolutionOption.THEIRS)
					textConflictsTextBox.Text = ResourcesMerge.ConflictHandlingTheirs;
				else if (mergeOptions.TextConflictResolution == MergeOptionsPage.ConflictResolutionOption.BASE)
					textConflictsTextBox.Text = ResourcesMerge.ConflictHandlingBase;

				// Populate Depth
				if (mergeOptions.Depth == SharpSvn.SvnDepth.Children)
					depthTextBox.Text = ResourcesMerge.SvnDepthChildren;
				else if (mergeOptions.Depth == SharpSvn.SvnDepth.Empty)
					depthTextBox.Text = ResourcesMerge.SvnDepthEmpty;
				else if (mergeOptions.Depth == SharpSvn.SvnDepth.Files)
					depthTextBox.Text = ResourcesMerge.SvnDepthFiles;
				else if (mergeOptions.Depth == SharpSvn.SvnDepth.Infinity)
					depthTextBox.Text = ResourcesMerge.SvnDepthInfinity;
				else if (mergeOptions.Depth == SharpSvn.SvnDepth.Unknown)
					depthTextBox.Text = ResourcesMerge.SvnDepthUnknown;

				// Populate Ignore Ancestry
				if (mergeOptions.IgnoreAncestry)
					ignoreAncestryTextBox.Text = ResourcesMerge.Yes;
				else
					ignoreAncestryTextBox.Text = ResourcesMerge.No;

				// Populate Allow Unversioned Obstructions
				if (mergeOptions.AllowUnversionedObstructions)
					unversionedObstructionsTextBox.Text = ResourcesMerge.Yes;
				else
					unversionedObstructionsTextBox.Text = ResourcesMerge.No;
			}
		}

		#region UI Events
		private void MergeSummaryPage_Load(object sender, EventArgs e)
		{
			PopulateUI();

			Wizard.PageChanged += new EventHandler(WizardDialog_PageChangeEvent);
		}

		private void performDryRunCheckBox_CheckedChanged(object sender, EventArgs e)
		{
			Wizard.PerformDryRun = performDryRunCheckBox.Checked;
		}
		#endregion
	}
}
