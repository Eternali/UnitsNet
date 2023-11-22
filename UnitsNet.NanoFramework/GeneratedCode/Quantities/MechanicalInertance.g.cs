//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by \generate-code.bat.
//
//     Changes to this file will be lost when the code is regenerated.
//     The build server regenerates the code before each build and a pre-build
//     step will regenerate the code on each local build.
//
//     See https://github.com/angularsen/UnitsNet/wiki/Adding-a-New-Unit for how to add or edit units.
//
//     Add CustomCode\Quantities\MyQuantity.extra.cs files to add code to generated quantities.
//     Add UnitDefinitions\MyQuantity.json and run generate-code.bat to generate new units or quantities.
//
// </auto-generated>
//------------------------------------------------------------------------------

// Licensed under MIT No Attribution, see LICENSE file at the root.
// Copyright 2013 Andreas Gullberg Larsen (andreas.larsen84@gmail.com). Maintained at https://github.com/angularsen/UnitsNet.

using System;
using UnitsNet.Units;

namespace UnitsNet
{
    /// <inheritdoc />
    /// <summary>
    ///     Mechanical Inertance is the ratio of mass force to acceleration representing the the resistance of a mechanical system to acceleration. This is simply a different way of representing mass, often used with mass-damper-inerter systems.
    /// </summary>
    public struct  MechanicalInertance
    {
        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        private readonly double _value;

        /// <summary>
        ///     The unit this quantity was constructed with.
        /// </summary>
        private readonly MechanicalInertanceUnit _unit;

        /// <summary>
        ///     The numeric value this quantity was constructed with.
        /// </summary>
        public double Value => _value;

        /// <inheritdoc />
        public MechanicalInertanceUnit Unit => _unit;

        /// <summary>
        ///     Creates the quantity with the given numeric value and unit.
        /// </summary>
        /// <param name="value">The numeric value to construct this quantity with.</param>
        /// <param name="unit">The unit representation to construct this quantity with.</param>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public MechanicalInertance(double value, MechanicalInertanceUnit unit)
        {
            _value = value;
            _unit = unit;
        }

        /// <summary>
        ///     The base unit of Duration, which is Second. All conversions go via this value.
        /// </summary>
        public static MechanicalInertanceUnit BaseUnit { get; } = MechanicalInertanceUnit.NewtonPerMeterPerSecondSquared;

        /// <summary>
        /// Represents the largest possible value of Duration
        /// </summary>
        public static MechanicalInertance MaxValue { get; } = new MechanicalInertance(double.MaxValue, BaseUnit);

        /// <summary>
        /// Represents the smallest possible value of Duration
        /// </summary>
        public static MechanicalInertance MinValue { get; } = new MechanicalInertance(double.MinValue, BaseUnit);

        /// <summary>
        ///     Gets an instance of this quantity with a value of 0 in the base unit Second.
        /// </summary>
        public static MechanicalInertance Zero { get; } = new MechanicalInertance(0, BaseUnit);
        #region Conversion Properties

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MechanicalInertanceUnit.KilogramForcePerMeterPerSecondSquared"/>
        /// </summary>
        public double KilogramsForcePerMeterPerSecondSquared => As(MechanicalInertanceUnit.KilogramForcePerMeterPerSecondSquared);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MechanicalInertanceUnit.NewtonPerMeterPerSecondSquared"/>
        /// </summary>
        public double NewtonsPerMeterPerSecondSquared => As(MechanicalInertanceUnit.NewtonPerMeterPerSecondSquared);

        /// <summary>
        ///     Gets a <see cref="double"/> value of this quantity converted into <see cref="MechanicalInertanceUnit.PoundForcePerG"/>
        /// </summary>
        public double PoundsForcePerG => As(MechanicalInertanceUnit.PoundForcePerG);

        #endregion

        #region Static Factory Methods

        /// <summary>
        ///     Creates a <see cref="MechanicalInertance"/> from <see cref="MechanicalInertanceUnit.KilogramForcePerMeterPerSecondSquared"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MechanicalInertance FromKilogramsForcePerMeterPerSecondSquared(double kilogramsforcepermeterpersecondsquared) => new MechanicalInertance(kilogramsforcepermeterpersecondsquared, MechanicalInertanceUnit.KilogramForcePerMeterPerSecondSquared);

        /// <summary>
        ///     Creates a <see cref="MechanicalInertance"/> from <see cref="MechanicalInertanceUnit.NewtonPerMeterPerSecondSquared"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MechanicalInertance FromNewtonsPerMeterPerSecondSquared(double newtonspermeterpersecondsquared) => new MechanicalInertance(newtonspermeterpersecondsquared, MechanicalInertanceUnit.NewtonPerMeterPerSecondSquared);

        /// <summary>
        ///     Creates a <see cref="MechanicalInertance"/> from <see cref="MechanicalInertanceUnit.PoundForcePerG"/>.
        /// </summary>
        /// <exception cref="ArgumentException">If value is NaN or Infinity.</exception>
        public static MechanicalInertance FromPoundsForcePerG(double poundsforceperg) => new MechanicalInertance(poundsforceperg, MechanicalInertanceUnit.PoundForcePerG);

        /// <summary>
        ///     Dynamically convert from value and unit enum <see cref="MechanicalInertanceUnit" /> to <see cref="MechanicalInertance" />.
        /// </summary>
        /// <param name="value">Value to convert from.</param>
        /// <param name="fromUnit">Unit to convert from.</param>
        /// <returns>MechanicalInertance unit value.</returns>
        public static MechanicalInertance From(double value, MechanicalInertanceUnit fromUnit)
        {
            return new MechanicalInertance(value, fromUnit);
        }

        #endregion

                #region Conversion Methods

                /// <summary>
                ///     Convert to the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>Value converted to the specified unit.</returns>
                public double As(MechanicalInertanceUnit unit) => GetValueAs(unit);

                /// <summary>
                ///     Converts this Duration to another Duration with the unit representation <paramref name="unit" />.
                /// </summary>
                /// <returns>A Duration with the specified unit.</returns>
                public MechanicalInertance ToUnit(MechanicalInertanceUnit unit)
                {
                    var convertedValue = GetValueAs(unit);
                    return new MechanicalInertance(convertedValue, unit);
                }

                /// <summary>
                ///     Converts the current value + unit to the base unit.
                ///     This is typically the first step in converting from one unit to another.
                /// </summary>
                /// <returns>The value in the base unit representation.</returns>
                private double GetValueInBaseUnit()
                {
                    return Unit switch
                    {
                        MechanicalInertanceUnit.KilogramForcePerMeterPerSecondSquared => _value * 9.80665,
                        MechanicalInertanceUnit.NewtonPerMeterPerSecondSquared => _value,
                        MechanicalInertanceUnit.PoundForcePerG => _value * 0.45359237,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to base units.")
                    };
                    }

                private double GetValueAs(MechanicalInertanceUnit unit)
                {
                    if (Unit == unit)
                        return _value;

                    var baseUnitValue = GetValueInBaseUnit();

                    return unit switch
                    {
                        MechanicalInertanceUnit.KilogramForcePerMeterPerSecondSquared => baseUnitValue / 9.80665,
                        MechanicalInertanceUnit.NewtonPerMeterPerSecondSquared => baseUnitValue,
                        MechanicalInertanceUnit.PoundForcePerG => baseUnitValue / 0.45359237,
                        _ => throw new NotImplementedException($"Can not convert {Unit} to {unit}.")
                    };
                    }

                #endregion
    }
}
