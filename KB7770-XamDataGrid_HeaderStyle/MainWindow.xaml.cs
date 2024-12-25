using System.Windows;

namespace KB7770_XamDataGrid_HeaderStyle
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            // データを設定
            var data = new List<Book>
            {
                new Book { Id = 0, Title = "枕草子", Author = "清少納言", Excerpt = "春はあけぼの。" },
                new Book { Id = 1, Title = "方丈記", Author = "鴨長明", Excerpt = "行く川のながれ" },
                new Book { Id = 2, Title = "徒然草", Author = "吉田兼好", Excerpt = "つれづれなるままに" },
            };
            DataGrid.DataSource = data;
        }
    }

    public class Book
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public string? Excerpt { get; set; }
    }
}