using NAudio.Wave;
using NAudio.Wave.SampleProviders;
using System;
using System.Threading;

namespace BusinessLogic
{
    public class AudioOperations
    {
        private WaveOutEvent outputDevice;
        private AudioFileReader audioFile;

        public void OnPlaybackStopped(object sender, StoppedEventArgs args)
        {
            outputDevice.Dispose();
            outputDevice = null;
            audioFile.Dispose();
            audioFile = null;
        }

        public void Playback()
        {
            if (outputDevice == null)
            {
                outputDevice = new WaveOutEvent();
                outputDevice.PlaybackStopped += OnPlaybackStopped;
            }
            if (audioFile == null)
            {
                audioFile = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio1.wav");
                outputDevice.Init(audioFile);
            }
            outputDevice.Play();
        }

        public void ConvertMp3ToWav()
        {
            using (var reader = new Mp3FileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Stuff.mp3"))
            {
                WaveFileWriter.CreateWaveFile(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\CovertedMp3ToWav.wav", reader);
            }
        }

        public void ConvertWavToMp3()
        {
            using (var reader = new MediaFoundationReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio2.wav"))
            {
                WaveFileWriter.CreateWaveFile(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\CovertedWavToMp3.mp3", reader);
            }
        }

        public void MixAudio()
        {
            using (var reader1 = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio2.wav"))
            using (var reader2 = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio3.wav"))
            {
                var mixer = new MixingSampleProvider(new[] { reader1, reader2 });
                WaveFileWriter.CreateWaveFile16(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\MixedAudio.wav", mixer);
            }
        }

        public void TrimWavFile(string inPath, string outPath, int cutFromStartmilli, int cutFromEndmilli)
        {
            using (WaveFileReader reader = new WaveFileReader(inPath))
            {
                using (WaveFileWriter writer = new WaveFileWriter(outPath, reader.WaveFormat))
                {
                    int bytesPerMillisecond = reader.WaveFormat.AverageBytesPerSecond / 1000;

                    int startPos = cutFromStartmilli * bytesPerMillisecond;
                    startPos = startPos - startPos % reader.WaveFormat.BlockAlign;

                    int endBytes = cutFromEndmilli * bytesPerMillisecond;
                    endBytes = endBytes - endBytes % reader.WaveFormat.BlockAlign;
                    int endPos = (int)reader.Length - endBytes;
                }
            }
        }

        public void MonoToStereo()
        {
            using (var inputReader = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Mono.mp3"))
            {
                var stereo = new MonoToStereoSampleProvider(inputReader);
                stereo.LeftVolume = 0.0f; // silence in left channel
                stereo.RightVolume = 1.0f; // full volume in right channel

                WaveFileWriter.CreateWaveFile16(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\MonoToStereo.wav", stereo);
            }
        }

        public void StereoToMono()
        {
            using (var inputReader = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Stereo.wav"))
            {
                var mono = new StereoToMonoSampleProvider(inputReader);
                mono.LeftVolume = 0.0f; // discard the left channel
                mono.RightVolume = 1.0f; // keep the right channel

                WaveFileWriter.CreateWaveFile16(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\StereoToMono.wav", mono);
            }
        }

        public void ConcatenateSkipTake()
        {
            var first = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio1.wav");
            var second = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio2.wav");
            var third = new AudioFileReader(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Audio3.wav");

            var playlist = new ConcatenatingSampleProvider(new[] { first, second, third });
            WaveFileWriter.CreateWaveFile16(@"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Playlist.wav", playlist);
        }

        public void Pitch()
        {
            var inPath = @"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Stuff.mp3";
            var semitone = Math.Pow(2, 1.0 / 12);
            var upOneTone = semitone * semitone;
            var downOneTone = 1.0 / upOneTone;
            using (var reader = new MediaFoundationReader(inPath))
            {
                var pitch = new SmbPitchShiftingSampleProvider(reader.ToSampleProvider());
                using (var device = new WaveOutEvent())
                {
                    pitch.PitchFactor = (float)upOneTone; // or downOneTone
                                                          // just playing the first 5 seconds of the file
                    device.Init(pitch.Take(TimeSpan.FromSeconds(5)));
                    device.Play();
                    while (device.PlaybackState == PlaybackState.Playing)
                    {
                        Thread.Sleep(500);
                    }
                }
            }
        }

        public void Resampler()
        {
            int outRate = 16000;
            var inFile = @"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Stuff.mp3";
            var outFile = @"D:\Facultate\EDITARE AUDIO-VIDEO\Lab5\FolderWithAudio\Resampler.wav";
            using (var reader = new Mp3FileReader(inFile))
            {
                var outFormat = new WaveFormat(outRate, reader.WaveFormat.Channels);
                using (var resampler = new MediaFoundationResampler(reader, outFormat))
                {
                    resampler.ResamplerQuality = 60;
                    WaveFileWriter.CreateWaveFile(outFile, resampler);
                }
            }
        }
    }
}
