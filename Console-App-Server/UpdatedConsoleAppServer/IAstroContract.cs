/*
 * 30074191 / Keanu Farro
 * 8/10/2024
 */
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ServiceModel;

namespace UpdatedConsoleAppServer
{
    /// <summary>
    /// Defines the service contract for astronomical calculations.
    /// </summary>
    [ServiceContract]
    internal interface IAstroContract
    {
        /// <summary>
        /// Converts a temperature from Celsius to another scale.
        /// </summary>
        /// <param name="tempInCelsius">Temperature in Celsius.</param>
        /// <returns>Converted temperature.</returns>
        [OperationContract]
        double tempConversion(double tempInCelsius);

        /// <summary>
        /// Measures the velocity of a star based on observed and rest wavelengths.
        /// </summary>
        /// <param name="observedWaveLength">Observed wavelength.</param>
        /// <param name="restWaveLength">Rest wavelength.</param>
        /// <returns>Star velocity.</returns>
        [OperationContract]
        double measureVelocity(double observedWaveLength, double restWaveLength);

        /// <summary>
        /// Calculates the distance to a star based on its angular size.
        /// </summary>
        /// <param name="arcSecondsAngle">Angular size in arcseconds.</param>
        /// <returns>Distance to the star.</returns>
        [OperationContract]
        double calculateStarDistance(double arcSecondsAngle);

        /// <summary>
        /// Calculates the event horizon of a black hole based on its mass.
        /// </summary>
        /// <param name="blackHoleMass">Mass of the black hole.</param>
        /// <returns>Event horizon radius.</returns>
        [OperationContract]
        double calculateEventHorizon(double blackHoleMass);
    }
}
