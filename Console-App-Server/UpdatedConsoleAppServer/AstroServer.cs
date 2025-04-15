using System;
using AstroMath;
using System.Security.Cryptography.X509Certificates;
using System.ServiceModel;

namespace UpdatedConsoleAppServer
{
    /// <summary>
    /// Implementation of the IAstroContract service contract.
    /// </summary>
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.Single)]
    internal class AstroServer : IAstroContract
    {
        private readonly AstroMathFunctions _astroMathFunctions = new AstroMathFunctions();

        /// <inheritdoc />
        public double tempConversion(double tempInCelsius)
        {
            return _astroMathFunctions.tempConversion(tempInCelsius);
        }

        /// <inheritdoc />
        public double measureVelocity(double observedWaveLength, double restWaveLength)
        {
            return _astroMathFunctions.measureVolicity(observedWaveLength, restWaveLength);
        }

        /// <inheritdoc />
        public double calculateStarDistance(double arcSecondsAngle)
        {
            return _astroMathFunctions.calculateStarDistance(arcSecondsAngle);
        }

        /// <inheritdoc />
        public double calculateEventHorizon(double blackHoleMass)
        {
            return _astroMathFunctions.calculateEventHorizon(blackHoleMass);
        }
    }
}
