/** This is an automatically generated class by FairyGUI. Please do not modify it. **/

using FairyGUI;
using Cysharp.Threading.Tasks;
using FairyGUI.Utils;
using GameFrameX.Runtime;

namespace Hotfix.UI
{
    public sealed partial class UILoginButton : FUI
    {
        public const string UIPackageName = "UILogin";
        public const string UIResName = "UILoginButton";
        public const string URL = "ui://f011l0h9xsvis9l";

        /// <summary>
        /// {uiResName}的组件类型(GComponent、GButton、GProcessBar等)，它们都是GObject的子类。
        /// </summary>
        public GButton self { get; private set; }




        public static UILoginButton Create(GObject go, FUI parent = null, object userData = null)
        {
            return new UILoginButton(go, userData, parent);
        }
        /*
        /// <summary>
        /// 通过此方法获取的FUI，在Dispose时不会释放GObject，需要自行管理（一般在配合FGUI的Pool机制时使用）。
        /// </summary>
        public static UILoginButton GetFormPool(GObject go)
        {
            var fui =  go.Get<UILoginButton>();
            if(fui == null)
            {
                fui = Create(go);
            }
            fui.isFromFGUIPool = true;
            return fui;
        }
        */

        protected override void InitView()
        {
            if(GObject == null)
            {
                return;
            }

            self = (GButton)GObject;
            
            var com = GObject.asCom;
            if(com != null)
            {

            }
        }

        public override void Dispose()
        {
            if (IsDisposed)
            {
                return;
            }

            base.Dispose();

            self = null;            
        }

        private UILoginButton(GObject gObject, object userData, FUI parent = null) : base(gObject, parent, userData)
        {
            // Awake(gObject);
        }
    }
}