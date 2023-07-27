using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Home_Work_11_1.Model
{
    internal class Passport
    {
        /// <summary>
        /// Уникальный идентификационный номер паспорта
        /// </summary>
        internal Guid Id { get; set; }

        /// <summary>
        /// Серия паспорта клиента
        /// </summary>
        internal string PassportSeries { get; set; }

        /// <summary>
        /// Номер паспорта клиента
        /// </summary>
        internal string PassportNumber { get; set; }

        /// <summary>
        /// Дата рождения клиента
        /// </summary>
        internal DateTime BirthDay { get; set; }

        public Passport(string passportSeries, string passportNumber, DateTime birthDay)
        {
            Id = new Guid();
            PassportSeries = passportSeries ?? throw new ArgumentNullException(nameof(passportSeries));
            PassportNumber = passportNumber ?? throw new ArgumentNullException(nameof(passportNumber));
            BirthDay = birthDay;
        }
    }
}
