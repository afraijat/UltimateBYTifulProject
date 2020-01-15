﻿using System;

public class Extension : Rentals
{
    public DateTime ExtensionDate { get; set; }
    public DateTime ExtensionPeriod = 14;

    public Extension(DateTime extensionDate)
    {
        this.ExtensionDate = DateTime.ParseExact(extensionDate, "dd/MM/yyyy", null);
    }
}