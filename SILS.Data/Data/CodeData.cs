using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SILS.Data
{
    public class CodeData : EntityData<Code>
    {
        public Code Get(string codeId)
        {
            SILSEntities context = CreateContext();
            return context.Codes.FirstOrDefault(a => a.CodeId == codeId);
        }
    }
}
