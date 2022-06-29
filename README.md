# 📝 Posts Application
- ASP.NET Core WEB application.
- Data used from: [JSONPlaceholder](https://jsonplaceholder.typicode.com/posts)

## How to use it? 🤔
- Run the project (using Visual Studio)
- Web tab will pop-up.
- In the main page you can:
   - See all the posts from API provider.
   - Insert a post (it will only return an object, which you have sent).
   - Get object details by pressing on the line of the list.
   - Filter objects by their UserID.
   - Sort objects ascending or descending by their properties.
   - Use pagination bar - walk through pages of the list.
   - Remove filters if needed.
- Use API:
   - Get all of the API data, by going to the page: /api/post/
   - Get an object by its ID from the API data, by going to the page: /api/post/{ID}
      - If the object is not available by ID, then returns 404.
