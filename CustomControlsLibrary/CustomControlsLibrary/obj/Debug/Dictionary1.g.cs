﻿#pragma checksum "..\..\Dictionary1.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "74DB7AA9E8E5EE8E1168183866963BD4"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.17929
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using CustomControlsLibrary;
using Microsoft.Windows.Themes;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Effects;
using System.Windows.Media.Imaging;
using System.Windows.Media.Media3D;
using System.Windows.Media.TextFormatting;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.Windows.Shell;


namespace CustomControlsLibrary {
    
    
    /// <summary>
    /// Dictionary1
    /// </summary>
    public partial class Dictionary1 : System.Windows.ResourceDictionary, System.Windows.Markup.IComponentConnector, System.Windows.Markup.IStyleConnector {
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/CustomControlsLibrary;component/dictionary1.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\Dictionary1.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            this._contentLoaded = true;
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "4.0.0.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        void System.Windows.Markup.IStyleConnector.Connect(int connectionId, object target) {
            System.Windows.EventSetter eventSetter;
            switch (connectionId)
            {
            case 1:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 30 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 31 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.ButtonUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 32 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.ButtonEnter);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeaveEvent;
            
            #line 33 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.ButtonLeave);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 2:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 66 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.MenuMouseDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 67 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.MenuMouseUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 68 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.MenuMouseEnter);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeaveEvent;
            
            #line 69 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.MenuMouseLeave);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.GotKeyboardFocusEvent;
            
            #line 70 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.MenuItemHighlighted);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.LostKeyboardFocusEvent;
            
            #line 71 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.KeyboardFocusChangedEventHandler(this.FocusLost);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            case 3:
            
            #line 79 "..\..\Dictionary1.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonDown += new System.Windows.Input.MouseButtonEventHandler(this.ItemMouseDown);
            
            #line default
            #line hidden
            
            #line 79 "..\..\Dictionary1.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeftButtonUp += new System.Windows.Input.MouseButtonEventHandler(this.ItemMouseUp);
            
            #line default
            #line hidden
            
            #line 79 "..\..\Dictionary1.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseEnter += new System.Windows.Input.MouseEventHandler(this.MouseEnterItem);
            
            #line default
            #line hidden
            
            #line 79 "..\..\Dictionary1.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseLeave += new System.Windows.Input.MouseEventHandler(this.MouseLeaveItem);
            
            #line default
            #line hidden
            break;
            case 4:
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseEnterEvent;
            
            #line 240 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.RadioButtonEnter);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.MouseLeaveEvent;
            
            #line 241 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseEventHandler(this.RadioButtonLeave);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonDownEvent;
            
            #line 242 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.RadioButtonDown);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            eventSetter = new System.Windows.EventSetter();
            eventSetter.Event = System.Windows.UIElement.PreviewMouseLeftButtonUpEvent;
            
            #line 243 "..\..\Dictionary1.xaml"
            eventSetter.Handler = new System.Windows.Input.MouseButtonEventHandler(this.RadioButtonUp);
            
            #line default
            #line hidden
            ((System.Windows.Style)(target)).Setters.Add(eventSetter);
            break;
            }
        }
    }
}

