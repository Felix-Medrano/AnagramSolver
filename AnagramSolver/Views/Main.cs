using AnagramSolver.Properties;
using AnagramSolver.TriePattern;

using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AnagramSolver.Views
{
  public partial class Main : Form
  {
    private string contentFile = string.Empty;

    public Main()
    {
      InitializeComponent();
    }

    private async void Main_Load(object sender, System.EventArgs e)
    {
      //await LoadFile();
    }

    private async Task LoadFile()
    {
      contentFile = Resources.en_US;
      int totalLength = contentFile.Length;
      int chunkSize = totalLength / 100; // Divide into 100 chunks for progress reporting

      for (int i = 0; i < totalLength; i += chunkSize)
      {
        // Update progress bar
        int progress = (i + chunkSize) * 100 / totalLength;
        progress = Math.Min(progress, totalLength);

        // Simulate processing a chunk of data
        await Task.Delay(10); // Simulate some asynchronous work

        bottomBarProgressBar.Value = progress;
        bottomBarLblState.Text = $"Loading... {progress}%";

        bottomBarProgressBar.Invalidate();
        bottomBarLblState.Invalidate();

        bottomBarProgressBar.Value = progress;
        if (progress == 100)
        {
          bottomBarLblState.Text = "File Loaded";

          MessageBox.Show(contentFile.Substring(0, 100));

          await Task.Delay(2000);

          bottomBarProgressBar.Visible =
          bottomBarLblState.Visible = false;
        }
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      //Stopwatch stopwatch = new Stopwatch();
      //stopwatch.Start();

      //Console.WriteLine(new ASFunctions().Normalize(txtInput.Text.ToLowCase().ToSort()));

      //stopwatch.Stop();

      //Console.WriteLine($"Time: {stopwatch.ElapsedMilliseconds}");

      Trie trie = new Trie();

      trie.Insert("Hola");
      trie.Insert("Ho");

      MessageBox.Show(trie.Search("Hola").ToString());
      MessageBox.Show(trie.Search("Hol").ToString());
      MessageBox.Show(trie.Search("Ho").ToString());
    }
  }
}
