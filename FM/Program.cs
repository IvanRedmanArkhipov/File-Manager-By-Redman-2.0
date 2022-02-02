using FM;

while (true)
{
    decoration dec = new();
    output op = new();
    copyPaste cp = new();
    create cr = new();
    rename rn = new();

    dec.Decoration();

    op.Output();

    line.print(52);

    info.Write();

    line.print(56);

    if (main.error == 1)
    {
        Console.WriteLine("Ошибка: " + main.errorMessage);
        main.error = 0;
    }

    line.print(58);

    var command = Console.ReadLine();
    string[] words = command.Split(' ');
    try
    {
        switch (words[0])
        {
            case "go":
                go.Go(words);
                break;
            case "copy":
                cp.Copy(words);
                break;
            case "paste":
                cp.Paste();
                break;
            case "del":
                del.Delete(words);
                break;
            case "create":
                cr.Create(words);
                break;
            case "rename":
                rn.Rename(words);
                break;
            case "help":
                help.Help();
                break;
            case "read":
                read.Read(words);
                break;
            case "search":
                search.Search(words);
                break;
        }
    }
    catch (Exception e)
    {
        main.error = 1;
        main.errorMessage = e.Message;
        Logger.WriteLine(e.Message);
    }
    Console.Clear();
}