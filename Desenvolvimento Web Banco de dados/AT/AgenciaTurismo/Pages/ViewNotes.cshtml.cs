using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Text.Encodings.Web;

public class ViewNotesModel : PageModel
{
    private readonly IWebHostEnvironment _env;
    public string[] Files { get; set; } = Array.Empty<string>();
    [BindProperty] public string NewNote { get; set; } = "";
    [BindProperty] public string SelectedFile { get; set; } = "";

    public ViewNotesModel(IWebHostEnvironment env) { _env = env; }

    public void OnGet()
    {
        var folder = Path.Combine(_env.WebRootPath, "files");
        Directory.CreateDirectory(folder);
        Files = Directory.GetFiles(folder, "*.txt").Select(Path.GetFileName).ToArray();
    }

    public IActionResult OnPostCreate()
    {
        var folder = Path.Combine(_env.WebRootPath, "files");
        Directory.CreateDirectory(folder);
        var fileName = $"note-{DateTime.UtcNow:yyyyMMddHHmmss}.txt";
        var safePath = Path.Combine(folder, fileName);
        System.IO.File.WriteAllText(safePath, NewNote);
        return RedirectToPage();
    }

    public IActionResult OnGetRead(string file)
    {
        var folder = Path.Combine(_env.WebRootPath, "files");
        var safePath = Path.Combine(folder, Path.GetFileName(file)); 
        if (!System.IO.File.Exists(safePath)) return NotFound();
        var content = System.IO.File.ReadAllText(safePath);
        ViewData["NoteContent"] = HtmlEncoder.Default.Encode(content);
        OnGet();
        return Page();
    }
}
