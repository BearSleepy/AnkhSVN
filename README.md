# Fork

Primarily intended to share a working stripped down AnkhSVN build setup, and a
working visx extention with the latest changes.

This version of AnkhSVN is compatible with all current and past versions and editions of Visual Studio 2022.

The rationale currently is explained in src/tools/*.props.targets

Notes:
1. Some parts of the build setup are missing and need to be added for a build.

   a. The SDK folders. Will be rectified soon with a compatible automated package. Or in the
   meantime, can make your own folder with a set of the lowest common denominator SDK dlls.

   See: src/tools/*.props.targets and src/tools/*.sdk.targets

   b. The Common References folder. Where your copy of SharpSVN goes.

   See: src/tools/*.props.targets and src/tools/*.references.targets

# AnkhSVN - Subversion Support for Visual Studio

Contents:
 1. Welcome
 2. Documentation References
 3. Participating in the AnkhSVN community
 
## 1. Welcome
 
  Thank you or checking out the sourcecode of AnkhSVN. You can always find
  the last version of this document on
 
    https://github.com/AmpScm/AnkhSVN
  
  If you have a Subversion client you can get the latest version of the 
  AnkhSVN sourcecode with the command:

  $ svn co https://github.com/ampscm/ankhsvn/trunk/ AnkhSVN
  
  If you have AnkhSVN 2.0 or later installed you can also automatically open the project
  directly in Visual Studio with AnkhSVN itself
  
    Click: File -> Open -> Subversion Project
  
  And then choose the right Solution (.sln) file below:
     https://github.com/ampscm/ankhsvn/trunk/src/
     
  In the next dialog choose a location where you wish to store your local
  working copy and click Ok.

  Of course you can also use your favorite git client to access our GitHub repository.
  
  
  Please read src/BUILD.txt for more information on how to test development
  versions of AnkhSVN after the checkout completes.


## 2. Documentation
 
  The development documentation of the AnkhSVN project is available in
 
    src/BUILD.txt         - How to build your own AnkhSVN version
    src/CONTRIBUTORS.txt  - List of committers and writers of patches
    LICENSE       - The sourcecode license of AnkhSVN
    
  A lot more information about what is going on can be found on
      https://github.com/AmpScm/AnkhSVN


## 3. Participating in the AnkhSVN community

  If you have any questions you can join the AnkhSVN user group on
      users@ankhsvn.open.collab.net
      
  Talk on IRC with developers: irc.freenode.net, channel #ankhsvn
  
  Or just use the discussion, issue and pull request support on GitHub
