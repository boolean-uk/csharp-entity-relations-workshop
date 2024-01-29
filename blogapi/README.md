# Example

- Use the different branches to see the different stages of the project

## Main branch

- The main branch is the starting point of the project
- It contains the basic structure of the project, with a repo, basic seeder, basic models with some relations
- The api returns the model data, without including nested (related) models

## relations-with-json-ignore

In this branch we are including the nested models when we fetch data in the repository layer.

If we don't use the [JsonIgnore] attribute, we get json serialization error.

Action: comment out [JsonIgnore] attribute in the various models, then try running some of the get requests in swagger to see the error.

Include the attribute again to fix the error. However, notice how we can only fetch the post nested properties and not the nested properties when we request the authors, for example, that is because we have marked the nested properties inside author with JsonIgnore, meaning they won't be converted (serialized) to json.

The error is of cyclical references

## relations-with-dtos

In this branch we fix the above issues by using DTOs (Data Transfer Objects).

With a DTO, we can control what data is returned to the client, and we can also control what data is sent to the server.

We can also use the DTO to map data from the model data returned by the repo into a data structure that guarantees there are no circular references.