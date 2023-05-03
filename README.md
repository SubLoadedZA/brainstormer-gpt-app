# ChatGPT Idea Brainstormer

ChatGPT Idea Brainstormer is a .NET console application that generates unique and creative ideas related to a given topic. It utilizes the OpenAI GPT-3 API to generate these ideas using the `text-davinci-002` model.

## Prerequisites

- [.NET SDK](https://dotnet.microsoft.com/download) (version 5.0 or higher)
- An [OpenAI API key](https://beta.openai.com/signup/)

## Installation

1. Clone the repository:

```bash
git clone https://github.com/SubLoadedZA/brainstormer-gpt-app.git
```

2. Update the apiKey variable in the Program.cs file with your OpenAI API key:

```
var apiKey = "your_api_key_here";
```

3. Build and run the application:

```
dotnet run 
```

4. Enter a topic to generate ideas.

5. The application will display generated ideas:

```
Generated ideas:
- Idea 1
- Idea 2
- Idea 3
- Idea 4
- Idea 5
```

## License

This project is licensed under the MIT License. See the LICENSE file for details.
