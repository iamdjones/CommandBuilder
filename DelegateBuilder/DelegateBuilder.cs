using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.VisualBasic.FileIO;
namespace DelegateBuilder
{




    public class CTEValidator
    {
        public static void Upload()
        {
            var validator = new CTEValidator();
            var data = ASCIIEncoding.ASCII.GetBytes(@"
Column1, Column2, Column3, Column4
");

            
            ValidationResult result = validator.Validate(data);
            if (result.HasError)
            {

            }
            
        }

        private ValidationResult Validate(byte[] data)
        {
            IList<string[]> dataset = ConvertToDataset(data);
            return Validate(dataset);

            //TextFieldParser p = new TextFieldParser(new MemoryStream(data));
            //string[] headers = null;
            //var fetchHeaders = true;
            //while (!p.EndOfData){
            //    if (headers == null)
            //    {
            //        headers = p.ReadFields();
            //        ValidateHeaders(headers);
            //    }
            //};
            throw new NotImplementedException();
        }

        private ValidationResult Validate(IList<string[]> dataset)
        {
            
            throw new NotImplementedException();
        }

        private IList<string[]> ConvertToDataset(byte[] data)
        {


            throw new NotImplementedException();

        }
    }

    class ValidationResult
    {
        private readonly string Error;

        public bool HasError { get { return string.IsNullOrEmpty(this.Error); } }
    }

    public interface ILooper
    {
        void Loop(ILooper looper);

    }

    public class Looper : ILooper
    {
        public void Loop(ILooper looper)
        {
            looper.Loop(this);
        }
    }

    public interface IClient
    {
        void Main();
    }

    public class LooperClient : IClient
    {
        public void Main()
        {
            ILooper looper1 = new Looper();
            looper1.Loop(looper1);
        }
    }




}
