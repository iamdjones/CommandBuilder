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


    public interface IBuilder
    {

    }
}
