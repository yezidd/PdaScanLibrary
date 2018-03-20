using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Pda.Scan.Library.RNPdaScanLibrary
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNPdaScanLibraryModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNPdaScanLibraryModule"/>.
        /// </summary>
        internal RNPdaScanLibraryModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNPdaScanLibrary";
            }
        }
    }
}
