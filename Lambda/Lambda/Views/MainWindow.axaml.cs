using System;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Interactivity;
using Avalonia.Markup.Xaml;
using Avalonia.ReactiveUI;
using Lambda.ViewModels;

namespace Lambda.Views
{
    public class MainWindow : ReactiveWindow<MainWindowViewModel>
    {
        public MainWindow()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
            
        }
        
        private void Button1_Click(object sender, RoutedEventArgs e)
        {
            TextBox boxOne = this.FindControl<TextBox>("Box1");
            TextBox boxTwo = this.FindControl<TextBox>("Box2");
            TextBox boxThree = this.FindControl<TextBox>("Box3");

            TextBox methodOutput = this.FindControl<TextBox>("OutputMethod");
            TextBox outputLambda = this.FindControl<TextBox>("OutputLambda");
            
            var numOne = int.Parse(boxOne.Text);
            var numTwo = int.Parse(boxTwo.Text);
            var numThree = int.Parse(boxThree.Text);
            
            (string, string)? output = ViewModel?.handleForm(numOne, numTwo, numThree);

            methodOutput.Text = output?.Item1;
            outputLambda.Text = output?.Item2;
            
            // ... Compare both outputs and check if they are the same
            // When they are equal, show a messagebox:
            // MessageBox.Show("Your message here");
        }
    }
}