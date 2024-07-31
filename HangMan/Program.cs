using HangMan.Common;
using HangMan.Common.WordGeneration.API;
using HangMan.Common.WordGeneration.FromFile;

while (true)
{
    HangManGame newHangManGame = new(new RandomWordApiWordGenerator());
    newHangManGame.Start();
}