﻿using System;
using System.ComponentModel.DataAnnotations;

namespace Theatre.DataProcessor.ImportDto
{
    public class ImportTheatreTicketDto
    {
        [Required]
        [Range(typeof(decimal), "1.00", "100.00")]
        public decimal Price { get; set; }

        [Required]
        [Range(typeof(sbyte),"1","10")]
        public sbyte RowNumber { get; set; }

        [Required]
        public int PlayId { get; set; }
    }
}