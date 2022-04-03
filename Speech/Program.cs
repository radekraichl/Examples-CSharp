using System;
using System.Speech.Synthesis;

namespace Speech
{
    class Program
    {
        static void Main()
        {
            // Initialize a new instance of the SpeechSynthesizer.  
            SpeechSynthesizer synth = new SpeechSynthesizer();

            // Configure the audio output.   
            synth.SetOutputToDefaultAudioDevice();

            // Speak a string.  
            synth.SpeakAsync("hello world, press any key to exit");

            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();
        }
    }
}
