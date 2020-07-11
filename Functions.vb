Imports Markdig
Module Functions

    Function bacaMateri(ByVal text)
        Dim markd, parsed As String
        markd = text
        parsed = Markdown.ToHtml(markd, New MarkdownPipelineBuilder().UseAdvancedExtensions().UseBootstrap().Build())

        Dim html As String
        html = "<!DOCTYPE html>
            <html>
              <head>
                <meta charset='utf-8'>
                <meta http-enquiv='X-UA-Compatible' content='IE=11'>
                <meta name='viewport' content='width=device-width, initial-scale=1'>
                <title>Hello Bulma!</title>
                <style>
                    *{
                        box-sizing:border-box;
                    }
                    body{
                        padding:10px 30px;
                        font-family: sans-serif
                    }

                    table {
                        border:1px solid;
                    }
                </style>
              </head>
              <body style='background-color:transparent'>
              <section class='container'>
                <div class='main'>
                  <h1 class='title' id='title'>
                  </h1>
                  " & parsed & "
                  <p>
                    My first website with <strong>Bulma</strong>!
                  </p>
                </div>
              </section>
              </body>
            </html>
            "
        Return html
    End Function
End Module
