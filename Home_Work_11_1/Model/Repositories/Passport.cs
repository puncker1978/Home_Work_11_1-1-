using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11_1.Model.Repositories
{
    public class Passport
    {
        /// <summary>
        /// Уникальный идентификационный номер паспорта
        /// </summary>
        public Guid Id { get; set; }

        /// <summary>
        /// Серия паспорта клиента
        /// </summary>
        public string PassportSeries { get; set; }

        /// <summary>
        /// Номер паспорта клиента
        /// </summary>
        public string PassportNumber { get; set; }

        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        public DateTime BirthDay { get; set; }

        public Passport(string passportSeries, string passportNumber, DateTime birthDay)
        {
            Id = Guid.NewGuid();
            PassportSeries = passportSeries ?? throw new ArgumentNullException(nameof(passportSeries));
            PassportNumber = passportNumber ?? throw new ArgumentNullException(nameof(passportNumber));
            BirthDay = birthDay;
        }
    }
}
