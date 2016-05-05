using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CommandBuilder.Interfaces
{
    //System Design
    //- IBuilder 
    //    - ReportBuilder 
    //        - Build 
    //        - BuildReport 
    //    - CommandBuilder 
    //        - Build 
    //        - BuildCommand 
    //        - BuildBuildProductCommand 
    //        - BuildRenderProductCommand 
    //        - BuildRunProductCommand 
    //    - ValidationBuilder 
    //        - Build 
    //        - BuildValidation 
    //- IProduct 
    //    - Report 
    //    - Command 
    //    - Validation 
    //- IDirector 
    //    - ReportController 
    //    - ValidatorController 
    //- ICommand 
    //    - BuildProductCommand 
    //    - RenderProductCommand 
    //    - RunProductCommand 
    //- IReceiver 
    //    - IBuilder 
    //    - IProduct 
    //- IInvoker 
    //    - ReportController 
    //    - ValidatorController


    // EVERYTHING IS A COMMAND


    // ABSTRACTION LAYER 1
    public interface ICommand {
        void Execute(IReceiver receiver);
    }
    public interface IReceiver {
        void Action();
    }

    public abstract class Invoker {
        IList<ICommand> Commands { get; }


        public virtual void Invoke()
        {

        }
    }


    public class PrintHelloCommand : ICommand
    {
        public void Execute(IReceiver receiver)
        {

        }
    }






    // ABSTRACTION LAYER 2
    public interface IBuilder : IReceiver { }
    public interface IProduct : IReceiver, ICommand { }
    public interface IDirector { }





    // ABSTRACTION LAYER 3
    



}