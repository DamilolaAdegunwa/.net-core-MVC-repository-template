using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GRA.Models
{
    public static class DictinaryService
    {
        public static Dictionary<string, string> DictService = new Dictionary<string, string> 
        {
            { "DataEmpty", "DataEmpty" },
            { "getSubjectByTin", "DatagetSubjectByTin" },
            { "taxpayerDataByInn", "DatataxpayerDataByInn" },
            { "TPpaymentDateByInn", "DataTPpaymentDateByInn" }
        };

        

        public static string GetPlural(string word)
        {
            // Try to get the result in the static Dictionary
            string result;
            if (DictService.TryGetValue(word, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }

        public static Dictionary<string, string> DictServiceName = new Dictionary<string, string>
        {
            { "getSubjectByTin", "Предоставление информации по юридическому лицу" },
            { "taxpayerDataByInn", "Сервис проверки наличия/отсутствия налоговой задолженности" },
            { "TPpaymentDateByInn", "Информация о фактически произведенных налоговых платежах в пользу государственного бюджета юридическими лицами" }
        };
        public static string GetPluralName(string word)
        {
            // Try to get the result in the static Dictionary
            string result;
            if (DictServiceName.TryGetValue(word, out result))
            {
                return result;
            }
            else
            {
                return null;
            }
        }
    }
}
