package group6.semester.project;

import group6.semester.project.grpcClient.post.PostGRPCClientImpl;

import group6.semester.project.grpcClient.user.GRPCUserClientImpl;
import group6.semester.project.model.Category;
import group6.semester.project.model.Post;
import group6.semester.project.model.User;

import group6.semester.project.services.UserService;
import org.springframework.boot.SpringApplication;
import org.springframework.boot.autoconfigure.SpringBootApplication;


import java.util.ArrayList;
import java.util.Date;
import java.util.List;

@SpringBootApplication

public class Sep3T2Application {

    public static void main(String[] args) {
//        try {
//            testUser();
//        } catch (Exception e) {
//            System.out.println(e.getMessage());
//        }
//        testPost();

        testCategory();

        testCategory();
        SpringApplication.run(Sep3T2Application.class, args);
    }

    private static void testCategory() {
        PostGRPCClientImpl postGRPCClient = new PostGRPCClientImpl();
        List<Category> categories = postGRPCClient.getAllCategories();
        for (Category ca :categories
        ) {
            System.out.println(ca.getName());
        }
    }

    private static void testUser() {
        User user = new User();
        user.setFirstName("TestFirstName");
        user.setLastName("TestLastName");
        user.setUsername("TestUsername12");
        user.setPassword("TestPassword21");
        user.setRole("User");
        GRPCUserClientImpl userClient = new GRPCUserClientImpl();
        User addUser = userClient.addUser(user);
        System.out.println(addUser.getUsername());
    }

    private static void testPost() {
        PostGRPCClientImpl postGRPCClient = new PostGRPCClientImpl();
        Post post = new Post();
        post.setTitle("hello");
        post.setPrice(10);
        post.setDescription("testDescription");
        post.setDateCreated(new Date());
        post.setImages(new ArrayList<>());
        post.setAddress("address");
        post.setCondition("bad");
        post.setPhoneNumber("rubbish");
        post.setEmail("sachin@gmail.com");
        post.setComments(new ArrayList<>());
        User user = new User();
        user.setUsername("sachin123");
        user.setPassword("sachin123");
        user.setFirstName("sachin");
        user.setLastName("Hero");
        user.setRole("user");
        post.setWriter(user);
        Post addPost = postGRPCClient.addPost(post, 1);
        System.out.println(addPost.getDescription());


    }

}
