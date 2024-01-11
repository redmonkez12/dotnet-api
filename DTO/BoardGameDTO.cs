﻿using System.ComponentModel.DataAnnotations;

namespace BgList.DTO;

public class BoardGameDTO
{
    [Required]
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Year { get; set; }
}