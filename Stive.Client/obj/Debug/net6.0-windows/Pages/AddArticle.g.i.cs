﻿#pragma checksum "..\..\..\..\Pages\AddArticle.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "00FAD4794E6B28BA4F07C130A82BB01810E9593B"
//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

using Stive.Client.Pages;
using System;
using System.Diagnostics;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Controls.Ribbon;
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


namespace Stive.Client.Pages {
    
    
    /// <summary>
    /// AddArticle
    /// </summary>
    public partial class AddArticle : System.Windows.Window, System.Windows.Markup.IComponentConnector {
        
        
        #line 14 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox designation;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox catgorySelector;
        
        #line default
        #line hidden
        
        
        #line 18 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.ComboBox fournisseurSelector;
        
        #line default
        #line hidden
        
        
        #line 20 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox description;
        
        #line default
        #line hidden
        
        
        #line 22 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox prix;
        
        #line default
        #line hidden
        
        
        #line 24 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox tva;
        
        #line default
        #line hidden
        
        
        #line 25 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button mediaPicker;
        
        #line default
        #line hidden
        
        
        #line 27 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnValider;
        
        #line default
        #line hidden
        
        
        #line 28 "..\..\..\..\Pages\AddArticle.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button btnAnnuler;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/Stive.Client;component/pages/addarticle.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\..\Pages\AddArticle.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.1.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.designation = ((System.Windows.Controls.TextBox)(target));
            return;
            case 2:
            this.catgorySelector = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 3:
            this.fournisseurSelector = ((System.Windows.Controls.ComboBox)(target));
            return;
            case 4:
            this.description = ((System.Windows.Controls.TextBox)(target));
            return;
            case 5:
            this.prix = ((System.Windows.Controls.TextBox)(target));
            return;
            case 6:
            this.tva = ((System.Windows.Controls.TextBox)(target));
            return;
            case 7:
            this.mediaPicker = ((System.Windows.Controls.Button)(target));
            
            #line 25 "..\..\..\..\Pages\AddArticle.xaml"
            this.mediaPicker.Click += new System.Windows.RoutedEventHandler(this.imgChoice);
            
            #line default
            #line hidden
            return;
            case 8:
            this.btnValider = ((System.Windows.Controls.Button)(target));
            
            #line 27 "..\..\..\..\Pages\AddArticle.xaml"
            this.btnValider.Click += new System.Windows.RoutedEventHandler(this.btnValider_Click);
            
            #line default
            #line hidden
            return;
            case 9:
            this.btnAnnuler = ((System.Windows.Controls.Button)(target));
            
            #line 28 "..\..\..\..\Pages\AddArticle.xaml"
            this.btnAnnuler.Click += new System.Windows.RoutedEventHandler(this.btnAnnuler_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

