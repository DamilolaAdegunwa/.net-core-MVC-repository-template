using System.Collections.Generic;
using GRA.Models;
using Microsoft.EntityFrameworkCore;

namespace GRA.Data
{
// ToDo: Решить вопрос с инкрементом ключей  
    public class FillData
    {
        public void Fill(ModelBuilder modelBuilder)
        {
            #region PagesAndAccess

            List<Page> page = new List<Page>
            {
                // new Page()
                // {
                //     Id = 44, Name = "Сервисы ГРС", URL = "#",
                //     IconName =
                //         "data:image/png;base64,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",
                //     ParentId = null
                // },
                new Page() {Id = 2, Name = "Пользователи", URL = "#", IconName = "fa fa-users", ParentId = 4},
                new Page()
                {
                    Id = 3, Name = "Лог запросов", URL = "/UserActivityLogs/Index", IconName = "fa fa-server",
                    ParentId = 4
                },
                new Page() {Id = 4, Name = "Справочники", URL = "#", IconName = "fa fa-book", ParentId = null},
                new Page() {Id = 5, Name = "Списки", URL = "#", IconName = "fa fa-table", ParentId = null},
                new Page()
                {
                    Id = 8, Name = "Список управлений", URL = "/Departments/Index", IconName = "fa fa-list-alt",
                    ParentId = 4
                },
                new Page()
                {
                    Id = 9, Name = "Добавление управления", URL = "/Departments/Create", IconName = "fa fa-plus-circle",
                    ParentId = 4
                },
                new Page()
                {
                    Id = 10, Name = "Список пользователей", URL = "/Roles/UserList", IconName = "fa fa-address-book",
                    ParentId = 2
                },
                new Page()
                {
                    Id = 11, Name = "Список адвокатов", URL = "/GraPerson", IconName = "fa fa-address-book",
                    ParentId = 5
                }
            };
            modelBuilder.Entity<Page>().HasData(
                page
            );
            modelBuilder.Entity<Department>().HasData(
                new Department() {Id = 1, Name = "Администрирование"}
            );

            List<RolePageMap> map = new List<RolePageMap>();
//Добавляем всё для админа
            for (int i = 0, j = map.Count + 1; i < page.Count; i++)
            {
                map.Add(
                        new RolePageMap() {Id = i+1, DepartmentId = 1, PageId = page[i].Id, IsActive = false}
                    );
            }

            modelBuilder.Entity<RolePageMap>().HasData(
                map
            );

            #endregion

            #region CountriesAndNationalities

            modelBuilder.Entity<Country>().HasData(new Models.Country {Id =  1, InstitutionName = "Кыргызстан" },
                new Models.Country {Id =  15, InstitutionName = "Белоруссия" },
                new Models.Country {Id =  83, InstitutionName = "Германия" },
                new Models.Country {Id =  120, InstitutionName = "Казахстан" },
                new Models.Country {Id =  125, InstitutionName = "Корея" },
                new Models.Country {Id =  156, InstitutionName = "Монголия" },
                new Models.Country {Id =  176, InstitutionName = "Пакистан" },
                new Models.Country {Id =  192, InstitutionName = "Россия" },
                new Models.Country {Id =  201, InstitutionName = "Узбекистан" },
                new Models.Country {Id =  202, InstitutionName = "Китай" },
                new Models.Country {Id =  203, InstitutionName = "Турция" },
                new Models.Country {Id =  204, InstitutionName = "Таджикистан" },
                new Models.Country {Id =  205, InstitutionName = "Азербайжан" },
                new Models.Country {Id =  206, InstitutionName = "Туркменистан" },
                new Models.Country {Id =  207, InstitutionName = "Грузия" },
                new Models.Country {Id =  208, InstitutionName = "Украина" },
                new Models.Country {Id =  209, InstitutionName = "Иран" },
                new Models.Country {Id =  210, InstitutionName = "Эстония" },
                new Models.Country {Id =  211, InstitutionName = "Афганистан" },
                new Models.Country {Id =  212, InstitutionName = "США" },
                new Models.Country {Id =  213, InstitutionName = "Армения" },
                new Models.Country {Id =  214, InstitutionName = "Палестина" },
                new Models.Country {Id =  215, InstitutionName = "Индия" },
                new Models.Country {Id =  216, InstitutionName = "Зимбабве" },
                new Models.Country {Id =  217, InstitutionName = "Нигерия" },
                new Models.Country {Id =  218, InstitutionName = "Сьерра-Леоне" },
                new Models.Country {Id =  219, InstitutionName = "Гвамател" },
                new Models.Country {Id =  220, InstitutionName = "Другое" }
            );

            modelBuilder.Entity<Nationality>().HasData(
                new Nationality {Id = 201, Name = "Кыргыз"},
                new Nationality {Id = 202, Name = "Русский"},
                new Nationality {Id = 203, Name = "Узбек"},
                new Nationality {Id = 204, Name = "Татарин"},
                new Nationality {Id = 205, Name = "Дунганин"},
                new Nationality {Id = 206, Name = "Уйгур"},
                new Nationality {Id = 207, Name = "Казах"},
                new Nationality {Id = 208, Name = "Турок"},
                new Nationality {Id = 209, Name = "Украинец"},
                new Nationality {Id = 210, Name = "Татжик"},
                new Nationality {Id = 211, Name = "Азербайджанец"},
                new Nationality {Id = 212, Name = "Кореец"},
                new Nationality {Id = 213, Name = "Немец"},
                new Nationality {Id = 214, Name = "Шор"},
                new Nationality {Id = 215, Name = "Хакас"},
                new Nationality {Id = 216, Name = "Китаец"},
                new Nationality {Id = 217, Name = "Карачаевец"},
                new Nationality {Id = 218, Name = "Лезгинец"},
                new Nationality {Id = 219, Name = "Грузин"},
                new Nationality {Id = 220, Name = "Тувинец"},
                new Nationality {Id = 221, Name = "Белорус"},
                new Nationality {Id = 222, Name = "Башкир"},
                new Nationality {Id = 223, Name = "Калмык"},
                new Nationality {Id = 224, Name = "Алтаец"},
                new Nationality {Id = 225, Name = "Туркмен"},
                new Nationality {Id = 226, Name = "Чуваш"},
                new Nationality {Id = 227, Name = "Чечен"},
                new Nationality {Id = 228, Name = "Монгол"},
                new Nationality {Id = 229, Name = "Армянин"},
                new Nationality {Id = 230, Name = "Лакец"},
                new Nationality {Id = 231, Name = "Каракалпак"},
                new Nationality {Id = 232, Name = "Черкес"},
                new Nationality {Id = 233, Name = "Цыган"},
                new Nationality {Id = 234, Name = "другое"},
                new Nationality {Id = 235, Name = "Самалиец"}
            );

            #endregion


            #region GRA dicts
                new GraLicenseBasement().FillData(modelBuilder);
                new GraLicenseStopBasement().FillData(modelBuilder);
                new GraLicenseTerminationBasement().FillData(modelBuilder);
                new GraLicenseWithdrawalBasement().FillData(modelBuilder);
                new GraGGUPExclusionBasement().FillData(modelBuilder);
                new GraGGUPSuspensionBasement().FillData(modelBuilder);
                new Sex().FillData(modelBuilder);
                new GraFormOfAdvocacy().FillData(modelBuilder);
                new GraGGUPHelpForm().FillData(modelBuilder);
                new GraGGUPSpecialization().FillData(modelBuilder);
                new GraLicenseStatus().FillData(modelBuilder);
            #endregion
            
        }
    }
}