using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegate_task.Models
{
    public class ProDocumentProgram : DocumentProgram
    {
        public sealed override void EditDocument()
        {
            Console.WriteLine("2. Document Edited");
        }

        public override void SaveDocument()
        {
            Console.WriteLine("3. Document Saved in doc format, for pdf format buy Expert packet");
        }
    }
}
