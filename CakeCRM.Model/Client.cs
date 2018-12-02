﻿using System;

namespace CakeCRM.Model
{
    /// <summary>
    /// Клиент.
    /// </summary>
    public class Client
    {
        /// <summary>
        /// Идентификатор.
        /// </summary>
        public int Id { get; set; }

        /// <summary>
        /// Имя.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Телефон.
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// Адрес.
        /// </summary>
        public string Address { get; set; }

        public override string ToString()
        {
            return String.Format("{0} {1}->{2}",Name,PhoneNumber,Address);
        }
    }
}