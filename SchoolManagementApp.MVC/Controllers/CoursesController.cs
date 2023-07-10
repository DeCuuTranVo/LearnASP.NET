using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using SchoolManagementApp.MVC.Data;


namespace SchoolManagementApp.MVC.Controllers
{
    [Authorize]
    public class CoursesController : Controller
    {
        // DbContext/ DbContext Subclass represent connections to the database
        private readonly SchoolManagementDbContext _context;

        public CoursesController(SchoolManagementDbContext context)
        {
            _context = context;
        }

        // GET: Courses
        public async Task<IActionResult> Index()
        {
            /*
                If (databaseTableExists) {
                    // wait for the connection, get the table courses, get all records in table as list
                    var recordsInTable = await _context.Courses.ToListAsync(); // Select * from table
                    // return the view with the data coming from the database
                    return View()
                }

                // return error message
                return Problem("Entity set 'SchoolManagementDbContext.Courses'  is null.");
            */

              return _context.Courses != null ? //Check if the Course table actually exist in the database
                          View(await _context.Courses.ToListAsync()) : // If yes, return the View with the data
                          Problem("Entity set 'SchoolManagementDbContext.Courses'  is null.");
        }

        // GET: Courses/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            // if id == null: check if the id is null
            // _context.Courses == null: check if the Courses table exist
            if (id == null || _context.Courses == null)
            {   
                // return 404
                return NotFound();
            }

            // wait for database connection, get the table Courses, get the first record that match the id, if it didnot see anything, it will return null
            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id); // lambda expression

            // if course is null, return 404
            if (course == null)
            {
                return NotFound();
            }

            // return view with an object of model type
            return View(course);
        }

        // GET: Courses/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Courses/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] // Post request
        [ValidateAntiForgeryToken] // Security: Anti so many form submission in case bot spam
        public async Task<IActionResult> Create([Bind("Id,Name,Code,Credits")] Course course) // I am interested in fields with these names Id,Name,Code,Credits in table Course, form data
        {
            // Use constraints of model (table) to make sure ModelState is valid
            if (ModelState.IsValid)
            {
                // Adding a record to the database
                _context.Add(course);

                // Save the change, commit change to database
                await _context.SaveChangesAsync();

                //Redirect, jump back to the listing page (Index), show a new record that is now in the database
                return RedirectToAction(nameof(Index));
            }
            // Return View
            return View(course);
        }

        // GET: Courses/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            // if id == null: check if the id is null
            // _context.Courses == null: check if the Courses table exist
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            // wait for database connection, get the table Courses, find the course by id, if it didnot see anything, it will return null
            var course = await _context.Courses.FindAsync(id);

            // if course is null, return 404
            if (course == null)
            {
                return NotFound();
            }

            // Return View with data
            return View(course);
        }

        // POST: Courses/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost] // Post request
        [ValidateAntiForgeryToken] // Security: Anti so many form submission in case bot spam
        public async Task<IActionResult> Edit(int id, [Bind("Id,Name,Code,Credits")] Course course) // form data
        {
            // check if course id exist
            if (id != course.Id)
            {
                return NotFound();
            }

            // check if model state is valid 
            if (ModelState.IsValid)
            {
                // Update that data in _context
                try
                {
                    // Update course object in database
                    _context.Update(course);
                    
                    // commit change to database
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException) // In case two users submit data to update the same record
                {
                    if (!CourseExists(course.Id)) // If the course not exist
                    {
                        return NotFound();
                    }
                    else // If the course exist, we dont know what to do with it
                    {
                        throw;
                    }
                }

                // Redirect to the Index page
                return RedirectToAction(nameof(Index));
            }

            // If the data is not valid, return the view with old data
            return View(course);
        }

        // GET: Courses/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            Console.WriteLine("Line 167");


            // if id == null: check if the id is null
            // _context.Courses == null: check if the Courses table exist
            if (id == null || _context.Courses == null)
            {
                return NotFound();
            }

            // wait for database connection, get the table Courses, get the first record that match the id, if it didnot see anything, it will return null
            var course = await _context.Courses
                .FirstOrDefaultAsync(m => m.Id == id);

            // if course is null, return 404
            if (course == null)
            {
                return NotFound();
            }

            // Return View with data
            return View(course);
        }

        // POST: Courses/Delete/5
        [HttpPost, ActionName("Delete")] // Post request, navigate to a particular name ("Delete")
        [ValidateAntiForgeryToken] // Security: Anti so many form submission in case bot spam
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            // Check if table exists
            if (_context.Courses == null)
            {
                return Problem("Entity set 'SchoolManagementDbContext.Courses'  is null.");
            }

            // Get the course by ID
            var course = await _context.Courses.FindAsync(id);

            // If we can find the course, remove it from the database
            if (course != null)
            {
                _context.Courses.Remove(course);
            }
            
            // Save changes
            await _context.SaveChangesAsync();

            // Redirect to Index
            return RedirectToAction(nameof(Index));
        }

        // Check if the course (record) exist
        private bool CourseExists(int id)
        {
          // Return True if there is an entry with same id, 
          // Return False if there is no entry with same id
          return (_context.Courses?.Any(e => e.Id == id)).GetValueOrDefault();
        }
    }
}
