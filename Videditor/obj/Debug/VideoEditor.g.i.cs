﻿#pragma checksum "..\..\VideoEditor.xaml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "8531A3086DB4E69DE3545AE8FAC570EE9254818B8AA484645D3047B77EB9913F"
//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

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
using Videditor;


namespace Videditor {
    
    
    /// <summary>
    /// VideoEditor
    /// </summary>
    public partial class VideoEditor : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 29 "..\..\VideoEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Canvas timeline;
        
        #line default
        #line hidden
        
        
        #line 31 "..\..\VideoEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle outsideStartArea;
        
        #line default
        #line hidden
        
        
        #line 37 "..\..\VideoEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Line timelineCursor;
        
        #line default
        #line hidden
        
        
        #line 38 "..\..\VideoEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle endTimelineMarker;
        
        #line default
        #line hidden
        
        
        #line 43 "..\..\VideoEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Shapes.Rectangle outsideEndArea;
        
        #line default
        #line hidden
        
        
        #line 60 "..\..\VideoEditor.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.MediaElement footage;
        
        #line default
        #line hidden
        
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
            System.Uri resourceLocater = new System.Uri("/Videditor;component/videoeditor.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\VideoEditor.xaml"
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
            switch (connectionId)
            {
            case 1:
            
            #line 12 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.ImportVideoHandler);
            
            #line default
            #line hidden
            return;
            case 2:
            
            #line 18 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.RenderVideoHandler);
            
            #line default
            #line hidden
            return;
            case 3:
            
            #line 19 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SetDurationVideoHandler);
            
            #line default
            #line hidden
            return;
            case 4:
            
            #line 20 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.MenuItem)(target)).Click += new System.Windows.RoutedEventHandler(this.SetVideoEffectHandler);
            
            #line default
            #line hidden
            return;
            case 5:
            
            #line 23 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.StackPanel)(target)).MouseUp += new System.Windows.Input.MouseButtonEventHandler(this.SeekCursorTimeline);
            
            #line default
            #line hidden
            return;
            case 6:
            this.timeline = ((System.Windows.Controls.Canvas)(target));
            
            #line 29 "..\..\VideoEditor.xaml"
            this.timeline.Loaded += new System.Windows.RoutedEventHandler(this.SetMarkersHandler);
            
            #line default
            #line hidden
            return;
            case 7:
            this.outsideStartArea = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 8:
            
            #line 32 "..\..\VideoEditor.xaml"
            ((System.Windows.Shapes.Rectangle)(target)).MouseMove += new System.Windows.Input.MouseEventHandler(this.SetStartMarkerHandler);
            
            #line default
            #line hidden
            return;
            case 9:
            this.timelineCursor = ((System.Windows.Shapes.Line)(target));
            return;
            case 10:
            this.endTimelineMarker = ((System.Windows.Shapes.Rectangle)(target));
            
            #line 38 "..\..\VideoEditor.xaml"
            this.endTimelineMarker.MouseMove += new System.Windows.Input.MouseEventHandler(this.SetEndMarkerHandler);
            
            #line default
            #line hidden
            return;
            case 11:
            this.outsideEndArea = ((System.Windows.Shapes.Rectangle)(target));
            return;
            case 12:
            
            #line 55 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.StartOrStopFootageHandler);
            
            #line default
            #line hidden
            return;
            case 13:
            
            #line 56 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ReverseSeekFootageHandler);
            
            #line default
            #line hidden
            return;
            case 14:
            
            #line 57 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.ContinueOrPauseFootageHandler);
            
            #line default
            #line hidden
            return;
            case 15:
            
            #line 58 "..\..\VideoEditor.xaml"
            ((System.Windows.Controls.Button)(target)).Click += new System.Windows.RoutedEventHandler(this.SeekFootageHandler);
            
            #line default
            #line hidden
            return;
            case 16:
            this.footage = ((System.Windows.Controls.MediaElement)(target));
            
            #line 60 "..\..\VideoEditor.xaml"
            this.footage.MouseEnter += new System.Windows.Input.MouseEventHandler(this.HoverVideoEffectHandler);
            
            #line default
            #line hidden
            
            #line 60 "..\..\VideoEditor.xaml"
            this.footage.MouseLeave += new System.Windows.Input.MouseEventHandler(this.HoutVideoEffectHandler);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

