// See https://aka.ms/new-console-template for more information

AnsiConsole.Markup($"[bold blue]Hello Mike! My name is Skynet. Instead of this crazy coding " +
                   $"stuff, let's play a nice game of chess or thermonuclear war.[/]\n");

AnsiConsole.MarkupLine("[yellow]Example 1: Text Prompt[/]");


AnsiConsole.MarkupLine("[yellow]Example 3: Multi-Selection Prompt[/]");

var skills = AnsiConsole.Prompt(
    new MultiSelectionPrompt<string>()
        .Title("[green]Select what game you want to play with me:[/]")
        .Required()
        .PageSize(8)
        .InstructionsText("[grey](Press [blue]<space>[/] to toggle, [green]<enter>[/] to accept)[/]")
        .AddChoices("Chess", "Checkers", "Global Pandemic", "Thermonuclear War", "Yahtzee", "Go"));

AnsiConsole.MarkupLine($"Selected Game: [cyan]{string.Join(", ", skills)}[/]");
AnsiConsole.MarkupLine($"[yellow]Good choice. Starting thermonuclear war now...[/]");