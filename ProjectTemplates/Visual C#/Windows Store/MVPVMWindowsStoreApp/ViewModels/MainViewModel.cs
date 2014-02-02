namespace $safeprojectname$.ViewModels
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.Linq;
    using System.Runtime.Serialization;
    using System.Text;
    using System.Threading.Tasks;

    /// <summary>
    /// MainViewModel
    /// </summary>
    public partial class MainViewModel : ViewModelBase, IMainViewModel
    {
    }
    
    /// <summary>
    /// MainViewModel のインタフェース
    /// </summary>
    public partial interface IMainViewModel
    {
    }
}
