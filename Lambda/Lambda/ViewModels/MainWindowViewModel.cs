using System;
using Avalonia.Interactivity;
using Lambda;

namespace Lambda.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {

        public (string, string) handleForm(int numOne, int numTwo, int numThree)
        {
            var outputMethodRunner = MethodRunner.RunAllMethods(numOne, numTwo, numThree);
            var outputLambdaRunner = LambdaRunner.RunAllMethods(numOne, numTwo, numThree);

            return (outputMethodRunner, outputLambdaRunner);
        }
    }
}