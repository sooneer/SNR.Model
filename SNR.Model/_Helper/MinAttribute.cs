﻿using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace SNR.Model;

[AttributeUsage(AttributeTargets.Property, AllowMultiple = false)]
public class MinAttribute : DataTypeAttribute
{
    public object Min
    { get { return _min; } }

    private readonly double _min;

    public MinAttribute(int min) : base("min")
    {
        _min = min;
    }

    public MinAttribute(double min) : base("min")
    {
        _min = min;
    }

    public override string FormatErrorMessage(string name)
    {
        if (ErrorMessage == null && ErrorMessageResourceName == null)
        {
            ErrorMessage = ValidationLocale.GetLocale("MinAttribute_Invalid", "tr");
        }

        return string.Format(CultureInfo.CurrentCulture, ErrorMessageString, name, _min);
    }

    public override bool IsValid(object value)
    {
        if (value == null) return true;

        double valueAsDouble;

        var isDouble = double.TryParse(Convert.ToString(value), out valueAsDouble);

        return isDouble && valueAsDouble >= _min;
    }
}