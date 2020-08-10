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
        public Code GetByNameAndUpper(string name, string upper = "")
        {
            SILSEntities context = CreateContext();
            return context.Codes.FirstOrDefault(a => a.Name == name && a.UpperclassId == upper);
        }

        public object GetLocation(string upperclassId = "")
        {
            SILSEntities context = CreateContext();
            var qurey = from x in context.Codes
                        where x.CodeId.Contains("L") && (x.UpperclassId == upperclassId)
                        select x;
            return qurey.ToList();
        }

        public List<Code> GetAllReports()
        {
            SILSEntities context = CreateContext();
            var query = from x in context.Codes
                        where x.CodeId.Contains("E")
                        select x;
            return query.ToList();
        }


    }
}
