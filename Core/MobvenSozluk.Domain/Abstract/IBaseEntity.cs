﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MobvenSozluk.Domain.Abstract
{
    public interface IBaseEntity
    {
        public int Id { get; set; }

    }
}
