/**
 * It's a controller that handles requests to the /user endpoint
 */
package group6.semester.project.controller;


import group6.semester.project.model.User;
import group6.semester.project.services.UserService;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

@RestController
public class UserController {
    // Don't use autowired on the field.

    private final UserService userService;

    public UserController(UserService userService) {
        this.userService = userService;
    }

    /**
     * The function takes a user object as a parameter, and returns a response entity with the added user object
     *
     * @param user The user object that is being passed in the request body.
     * @return A ResponseEntity object is being returned.
     */
    @PostMapping(value = "/user")
    public ResponseEntity addUser(@RequestBody User user) {
        try{
            System.out.println(user.getUsername());
            User addedUser = userService.CreateUserAsync(user);
            return ResponseEntity.ok().body(addedUser);
        }
        catch (Exception e){
            return new ResponseEntity<>(e.getMessage(), HttpStatus.BAD_REQUEST);
        }
   }


  /**
   * The function takes a username as a path variable, and returns a user object
   *
   * @param username The username of the user you want to get.
   * @return A ResponseEntity object is being returned.
   */
  @GetMapping(value = "/user/{username}")
  @ResponseBody
  public ResponseEntity getUser(@PathVariable String username){
    try {

      User userFromServer = userService.GetUserAsync(username);
      return ResponseEntity.ok(userFromServer);
    } catch (Exception e) {
        System.out.println(e.getMessage());
      return new ResponseEntity<>(e.getMessage(), HttpStatus.NOT_FOUND);
    }
  }

    /**
     * The function takes in a username and password, and returns a user object if the username and password are correct
     *
     * @param username The username of the user you want to get.
     * @param password The password of the user
     * @return A user object
     */
    @GetMapping(value = "/user/{username}/{password}")
    @ResponseBody
    public ResponseEntity getUser(@PathVariable String username, @PathVariable String password){
        try {
            User userFromServer = userService.GetUserLogin(username,password);
            return ResponseEntity.ok(userFromServer);
        } catch (Exception e) {
            System.out.println(e.getMessage());
            return new ResponseEntity<>(e.getMessage(), HttpStatus.NOT_FOUND);
        }
    }

}
