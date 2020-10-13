using System.ComponentModel.DataAnnotations;

namespace GRA.Models
{
    public enum EnumServiceCode
    {
        [Display(Name = "Сведения об адресной регистрации граждан (ПИН)")]
        asbAddress,
        [Display(Name = "Сведения о смерти (ПИН)")]
        zagsDeathActByPin,
        [Display(Name = "Сведения о рождении ребенка (ПИН)")]
        zagsPinBirthAct,
        [Display(Name = "Сведения о семейном статусе (ПИН)")]
        zagsMaritalStatus,
        [Display(Name = "Сведения о заключении брака (ПИН)")]
        zagsPinMarriageAct,
        [Display(Name = "Сведения о ПИНах граждан (ФИО + дата рождения)")]
        zagsPinNameChangeAct,
        [Display(Name = "Сведения о ПИНах граждан (ФИО + дата рождения)")]
        zagsPinsByNSPDate,
        [Display(Name = "Сведения о паспортных данных граждан (серия и №)")]
        passportDataByPSN,
        [Display(Name = "Cведения об иностранных гражданах (№ документа)")]
        foreignByDoc,
        [Display(Name = "Сведения о персональных данных граждан (ПИН)")]
        zagsDataByPin,
        [Display(Name = "Сведения о статусе гражданства (ПИН)")]
        citizenshipStatusByPin,
        [Display(Name = "Сведения о транспортном средстве (ПИН)")]
        transportByPin
    }
}
