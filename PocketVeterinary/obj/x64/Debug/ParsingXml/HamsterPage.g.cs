﻿#pragma checksum "C:\Users\hayfa\Documents\Visual Studio 2015\NewFolderForProjects\PocketVeterinary\PocketVeterinary\ParsingXml\HamsterPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "B4C866D162802D04EB717DCE234D32ED"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PocketVeterinary.ParsingXml
{
    partial class HamsterPage : 
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
                    this.MySplitView = (global::Windows.UI.Xaml.Controls.SplitView)(target);
                }
                break;
            case 2:
                {
                    this.IconsListBox = (global::Windows.UI.Xaml.Controls.ListBox)(target);
                    #line 57 "..\..\..\ParsingXml\HamsterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.ListBox)this.IconsListBox).SelectionChanged += this.IconsListBox_SelectionChanged;
                    #line default
                }
                break;
            case 3:
                {
                    this.HomeListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 4:
                {
                    this.VetsListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 5:
                {
                    this.ServicesListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 6:
                {
                    this.GuideListBoxItem = (global::Windows.UI.Xaml.Controls.ListBoxItem)(target);
                }
                break;
            case 7:
                {
                    this.HamburgerButton = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 25 "..\..\..\ParsingXml\HamsterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.HamburgerButton).Click += this.HamburgerButton_Click;
                    #line default
                }
                break;
            case 8:
                {
                    this.exitBtn = (global::Windows.UI.Xaml.Controls.Button)(target);
                    #line 34 "..\..\..\ParsingXml\HamsterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.Button)this.exitBtn).Click += this.exitBtn_Click;
                    #line default
                }
                break;
            case 9:
                {
                    this.foriteBtn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 29 "..\..\..\ParsingXml\HamsterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.foriteBtn).Click += this.foriteBtn_Click;
                    #line default
                }
                break;
            case 10:
                {
                    this.profileBtn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 30 "..\..\..\ParsingXml\HamsterPage.xaml"
                    ((global::Windows.UI.Xaml.Controls.AppBarButton)this.profileBtn).Click += this.profileBtn_Click;
                    #line default
                }
                break;
            case 11:
                {
                    this.aboutBtn = (global::Windows.UI.Xaml.Controls.AppBarButton)(target);
                    #line 31 "..\..\..\ParsingXml\HamsterPage.xaml"
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

