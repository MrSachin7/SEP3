﻿using System.Runtime.InteropServices;
using Entities.Models;
using Microsoft.AspNetCore.Components.Forms;
namespace Contracts; 

public interface IPostService {
    Task<Post> AddPostAsync(int subCategoryId, Post postToAdd,[Optional] MultipartFormDataContent formDataContent);

    Task<string> AddImage(MultipartFormDataContent form);
    Task<List<Category>> GetALlCategoriesAsync();

    Task<List<Post>> GetPostsByName(string name);
    Task<List<Post>> GetAllPosts();
}