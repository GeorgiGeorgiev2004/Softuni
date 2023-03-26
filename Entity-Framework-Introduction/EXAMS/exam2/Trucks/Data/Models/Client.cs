﻿using System.ComponentModel.DataAnnotations;

namespace Trucks.Data.Models;
public class Client
{
    public Client()
    {
        ClientsTrucks = new HashSet<ClientTruck>();
    }
    public int Id { get; set; }
    [Required]
    public string Name { get; set; }
    [Required]
    public string Nationality { get; set; }
    [Required]
    public string Type { get; set; }

    public ICollection<ClientTruck> ClientsTrucks { get; set; }
}
