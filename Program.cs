// See https://aka.ms/new-console-template for more information
using Cooperative_Race_Game.Asset.Script;

Console.WriteLine("書き込みテスト");
Update_ReleaseData.Write("Test", "TestContent");

Console.WriteLine("データの更新を開始");

Update_ReleaseData.Update();

Console.WriteLine("更新終了");
