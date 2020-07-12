Imports Markdig
Module Functions

    Function bacaMateri(ByVal text)
        Dim parsed = Markdown.ToHtml(text, New MarkdownPipelineBuilder().UseAdvancedExtensions().Build())

        Dim html = "<!DOCTYPE html><html><head><meta charset='utf-8'><meta http-enquiv='X-UA-Compatible' content='IE=11'><meta name='viewport' content='width=device-width, initial-scale=1'><title>Lets Learn English</title><style>*{box-sizing:border-box;}body{padding:5px 30px;font-family:sans-serif}h1,h2,h3,h4,h5,h6{color:#dc3545;}.container{max-height:100vh;overflow:hidden;}table{color:#212529;width:100%;border-collapse:collapse;}thead{display:table-header-group;vertical-align:middle;border-color:inherit;}th{color:#fff;background-color:#dc3545;border-color:#454d55;}tr{display:table-row;vertical-align:inherit;border-color:inherit;}tr:nth-of-type(odd){background-color:rgba(0,0,0,.05);}td,table th{padding:0.50rem;vertical-align:top;border-top:1px solid #dee2e6;display:table-cell;}</style></head><body style='background-color:transparent'><section class='container'>" & parsed & "</section></body></html>"
        Return html
    End Function
End Module
