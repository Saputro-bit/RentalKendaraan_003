﻿using System;
using System.Collections.Generic;

namespace RentalKendaraan_03.Models
{
    public partial class KondisiKendaraan
    {
        public int IdKondisi { get; set; }
        public string NamaKondisi { get; set; }

        public Pengembalian Pengembalian { get; set; }
    }
}
