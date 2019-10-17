using System;
using System.Threading;
using Meadow;
using Meadow.Devices;
using Meadow.Foundation.Audio;
using Meadow.Hardware;
using Meadow.Peripherals.Speakers;

namespace HalloweenTechorations
{
    public class MeadowApp : App<F7Micro, MeadowApp>
    {
        IDigitalOutputPort _orangeLed;
        IToneGenerator _speaker;
        IAnalogInputPort _photoResistor;

        public MeadowApp()
        {
            ConfigurePorts();
        }

        public void ConfigurePorts()
        {
            Console.WriteLine("Creating Outputs...");
            _orangeLed = Device.CreateDigitalOutputPort(Device.Pins.D10);
            _speaker = new PiezoSpeaker(Device.CreatePwmPort(Device.Pins.D11));
            _photoResistor = Device.CreateAnalogInputPort(Device.Pins.A00);
            _photoResistor.Changed += _photoResistor_Changed;
        }

        private void _photoResistor_Changed(object sender, FloatChangeResult e)
        {
            throw new NotImplementedException();
        }

        private void PlayScaryHalloweenJingle()
        {

        }

        private void RunLightShow()
        {

        }
    }
}
