using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Entities;

public class team
{
    public int Id { get; set; }
    
    public string? FullName { get; set; }
    public string? Job { get; set; }
    public string? Photo { get; set; }

}
