﻿#pragma checksum "C:\Users\hayfa\Documents\Visual Studio 2015\NewFolderForProjects\PocketVeterinary\PocketVeterinary\VetsPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "AD4DA84FB1E12BEA879A288BFC08E450"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PocketVeterinary
{
    partial class VetsPage : 
        global::Windows.UI.Xaml.Controls.Page, 
        global::Windows.UI.Xaml.Markup.IComponentConnector,
        global::Windows.UI.Xaml.Markup.IComponentConnector2
    {
        /// <summary>
        /// Connect()
        /// </summary>
        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void Connect(int connectionId, object target)
        {
            switch(connectionId)
            {
            case 1:
                {
                    this.VisualStateGroup = (global::Windows.UI.Xaml.VisualStateGroup)(target);
                }
                break;
            case 2:
                {
                    this.phone1 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 3:
                {
                    this.phone2 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 4:
                {
                    this.tablet1 = (global::Windows.UI.Xaml.VisualState)(target);
                }
                break;
            case 5:
                {
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 6:
                {
                    this.IconsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 63 "..\..\..\VetsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.IconsListBox).SelectionChanged += this.IconsListBox_SelectionChanged;
                    #line default
                }
                break;
            case 7:
                {
                    this.HomeListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 8:
                {
                    this.VetsListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 9:
                {
                    this.ServicesListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 10:
                {
                    this.GuideListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 11:
                {
                    this.gridVenues = (global::Windows.UI.Xaml.Controls.GridView)(target);
                }
                break;
            case 12:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 42 "..\..\..\VetsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 13:
                {
                    this.foriteBtn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 45 "..\..\..\VetsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.foriteBtn).Click += this.foriteBtn_Click;
                    #line default
                }
                break;
            case 14:
                {
                    this.profileBtn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 46 "..\..\..\VetsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.profileBtn).Click += this.profileBtn_Click;
                    #line default
                }
                break;
            case 15:
                {
                    this.aboutBtn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 47 "..\..\..\VetsPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.aboutBtn).Click += this.aboutBtn_Click;
                    #line default
                }
                break;
            default:
                break;
            }
            this._contentLoaded = true;
        }

        [global::System.CodeDom.Compiler.GeneratedCodeAttribute("Microsoft.Windows.UI.Xaml.Build.Tasks"," 14.0.0.0")]
        [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public global::Windows.UI.Xaml.Markup.IComponentConnector GetBindingConnector(int connectionId, object target)
        {
            global::Windows.UI.Xaml.Markup.IComponentConnector returnValue = null;
            return returnValue;
        }
    }
}

