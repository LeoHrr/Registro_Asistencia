﻿#pragma checksum "..\..\..\Ingreso.xaml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "029E3F7BCAE964EE8B39F4F248A5616565D15769"
//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

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
using proyecto_final;


namespace proyecto_final {
    
    
    /// <summary>
    /// Ingreso
    /// </summary>
    public partial class Ingreso : System.Windows.Controls.Page, System.Windows.Markup.IComponentConnector {
        
        
        #line 12 "..\..\..\Ingreso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock usuario;
        
        #line default
        #line hidden
        
        
        #line 13 "..\..\..\Ingreso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ingreso_user;
        
        #line default
        #line hidden
        
        
        #line 14 "..\..\..\Ingreso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button iniciar_sesion;
        
        #line default
        #line hidden
        
        
        #line 15 "..\..\..\Ingreso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBlock contraseña;
        
        #line default
        #line hidden
        
        
        #line 16 "..\..\..\Ingreso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.TextBox Ingreso_password;
        
        #line default
        #line hidden
        
        
        #line 17 "..\..\..\Ingreso.xaml"
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1823:AvoidUnusedPrivateFields")]
        internal System.Windows.Controls.Button volver;
        
        #line default
        #line hidden
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Uri resourceLocater = new System.Uri("/proyecto_final;component/ingreso.xaml", System.UriKind.Relative);
            
            #line 1 "..\..\..\Ingreso.xaml"
            System.Windows.Application.LoadComponent(this, resourceLocater);
            
            #line default
            #line hidden
        }
        
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        [System.CodeDom.Compiler.GeneratedCodeAttribute("PresentationBuildTasks", "6.0.9.0")]
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Never)]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Design", "CA1033:InterfaceMethodsShouldBeCallableByChildTypes")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Maintainability", "CA1502:AvoidExcessiveComplexity")]
        [System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1800:DoNotCastUnnecessarily")]
        void System.Windows.Markup.IComponentConnector.Connect(int connectionId, object target) {
            switch (connectionId)
            {
            case 1:
            this.usuario = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 2:
            this.Ingreso_user = ((System.Windows.Controls.TextBox)(target));
            
            #line 13 "..\..\..\Ingreso.xaml"
            this.Ingreso_user.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ingreso_user_TextChanged);
            
            #line default
            #line hidden
            return;
            case 3:
            this.iniciar_sesion = ((System.Windows.Controls.Button)(target));
            
            #line 14 "..\..\..\Ingreso.xaml"
            this.iniciar_sesion.Click += new System.Windows.RoutedEventHandler(this.iniciar_sesion_Click);
            
            #line default
            #line hidden
            return;
            case 4:
            this.contraseña = ((System.Windows.Controls.TextBlock)(target));
            return;
            case 5:
            this.Ingreso_password = ((System.Windows.Controls.TextBox)(target));
            
            #line 16 "..\..\..\Ingreso.xaml"
            this.Ingreso_password.TextChanged += new System.Windows.Controls.TextChangedEventHandler(this.Ingreso_pass_TextChanged);
            
            #line default
            #line hidden
            return;
            case 6:
            this.volver = ((System.Windows.Controls.Button)(target));
            
            #line 17 "..\..\..\Ingreso.xaml"
            this.volver.Click += new System.Windows.RoutedEventHandler(this.volver_Click);
            
            #line default
            #line hidden
            return;
            }
            this._contentLoaded = true;
        }
    }
}

