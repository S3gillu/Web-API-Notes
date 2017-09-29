using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebAPI_Notes
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            Web Api:-
  | -Properties
       | -Assembly - info.cs
            | -An assembly provides a fundamental unit of physical code grouping.
            | -An assembly is a collection of types and resources that forms a logical unit of functionality.
            | -All types in the.NET framework must exist in assemblies.
            | -CLR does not support types outside assemblies.
            | -It is stored as an (.exe) or(dll) file.
            | -It can be either private or shared.By dafault assemblies are private. 
            |- Purpose:-
                |- Security :- It is a unit at which security permissions are requested and granted.
                               Here we can establish Identity and Trust . There are two levels for this
                              level of assembly (1) Strong names(2)Signcode.exe

                                 Signing an assembly with a strong name adds public key encryption to the
                                  assembly.This ensures name uniqueness and prevents substituting another
                                  assembly with the same name for the assembly that you provided.

                                  The signcode.exe tool embeds a digital certificate in the assembly. This
                                  allows users of the assembly to verify the identity of the assembly's 
                                  developer by using a public or private trust hierarchy.

                                  The common language runtime also uses internal hashing information, in 
                                  conjunction with strong names and signcode, to verify that the assembly
                                  being loaded has not been altered after it was built.
 
                |- Type Identity :- The identity of a type depends on the assembly where that type is defined.
                                    That is, if you define a type named DataStore in one assembly, and a type
                                    named DataStore in another assembly, the.NET Framework can tell them
                                    apart because they are in two different assemblies.

                                     We can't define two different types With the same name in same assembly.

                |- Reference Scope :- The assembly is also the location of reference information in general.
                                      Each assembly contains information on references in two directions:

                                     (1) The assembly contains metadata that specifies the types and resources
                                     within the assembly that are exposed to code outside of the assembly.
                                     For example, a particular assembly could expose a public type named
                                     Customer with a public property named AccountBalance

                                     (2)The assembly contains metadata specifying in other assemblies on which
                                       it depends.For example, a particular assembly might specify that it
                                       depends on the System.Windows.Forms.dll assembly.

                |- Versioning :- Each assembly has a 128-bit version number that is presented as a
                                 set of four decimal pieces:
                                                            Major.Minor.Build.Revision
                                 For example , version number might be 3.5.0.126

                |- Deployement :- Assemblies are the natural unit of deployment.

                |- The Assembly Manifest :- It is a set of metadata with information about the assembly.
                                            It contains these items :
                                            (a) The assembly name,title,description,copyrights and version
                                            (b) The culture or language the assembly supports
                                                (not required in all assemblies).
                                            (c) The public key for any strong name assigned to the assembly
                                                (not required in all assemblies).
                                            (d) A list of files in the assembly with hash information.
                                            (e) Information on exported types.
                                            (f) Information on referenced assemblies.
                                           
                |- The Global Assembly Cache :- It contains assemblies that are designed to be shared by
                                                multiple applications.
                
                |- Component Object Model (COM) :- It  is a platform-independent, distributed, object-oriented
                                              system for creating binary software components that can interact. */


            ///////////////////****************************************************************/////////////////////////////

            /*
           Web Api 2 :-WEB API allows us to program to an interface rather than concrete implementation.

 |- Refrences 
     |- AppStart
         |-BundleConfig:- Here we register our " CSS and JS files " so that they can be bundled and minified.

                          "Bundling and Minification" are two techniques to improve request load time by
                           reducing the number of requests to the server and reducing the size of requested
                           assets (such as CSS and JS).
                           Microsoft provides assembly "Microsoft.Web.Optimization" for the same.

         |-FilterConfig:- Used to add extra logic before or after action method executes.Filters can be used
                          to provide cross-cutting features such as logging, exception handling, performance
                          measurement, authentication and authorization.

                          Filters are actually attributes that can be applied on the Web API controller
                          or one or more action methods.

                         filter class implements necessary interfaces and provides virtual
                        methods, so that they can be overridden to add extra logic.

Filter Type Interface             Class Description

Simple Filter           IFilter                 --                          Defines the methods that are used in a filter
Action Filter           IActionFilter ActionFilterAttribute           Used to add extra logic before or after action methods execute.
Authentication Filter   IAuthenticationFilter         --                        Used to force users or clients to be authenticated before action methods execute.
Authorization Filter    IAuthorizationFilter AuthorizationFilterAttribute    Used to restrict access to action methods to specific users or groups.
Exception Filter    IExceptionFilter ExceptionFilterAttribute    Used to handle all unhandled exception in Web API.
Override Filter         IOverrideFilter             --                      Used to customize the behaviour of other filter for individual action method.


         |-IdentityConfig :- Used for Authentication/Authorization.This is for Web API Security.
                            Here we defines "ApplicationUserManager" for Web API Application.
                            Here we also define the password requirements for the application as well as 
                            "place potential constraints" on name and email address.

                           This is also where we might define two-factor authentication providers for email or SMS text,
                           and also where we might define email account confirmation configuration.

                            "RoleManager" and "DbInitializer" is also defined here.


         |-RouteConfig :- Used to register various route patterns for the application.
                          It maps request URL to a specific controller action using a Routing Table.

         |-Startup.Auth :- Also used for Authentication/ Authorization.
                           The primary Authentication and Authorization strategy in Web Api is token based.

                           To access any secured portion we will be need to present an access token as a
                           part of any incoming Http request.

                           contains a partial class, Startup, which extends the default Startup class defined
                           at the root level of the project.

                           In " ConfigureAuth() ", here we configure options for cookie and token authentication,
                          and, optionally, allow sign-in via various third-party providers such as Facebook
                           and Twitter.




         |-WebApiConfig :- Here we set up default routes for incoming requests.
                           Web API supports code based configuration so this file is used.

                           For more details visit "www.tutorialsteacher.com/webapi". */



            https://basicsclear.wordpress.com/2017/09/17/angular-project-publish-to-git-hub/
            https://loiane.com/2017/08/angular-reactive-forms-trigger-validation-on-submit/









        }
    }
}
