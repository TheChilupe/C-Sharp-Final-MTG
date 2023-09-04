﻿using Final___Magix.DataContext;
using Microsoft.AspNetCore.Mvc;

namespace Final___Magix.Controllers
	{

	public class CardApiResponse : Controller
		{

		private readonly CardContext _context;

		public CardApiResponse(CardContext context)
			{
			_context = context;
			}

		// GET: CardController
		public ActionResult Index()
			{
			return View();
			}

		// GET: CardController/Details/5
		public ActionResult Details(int id)
			{
			return View();
			}

		// GET: CardController/Create
		public ActionResult Create()
			{
			return View();
			}

		// POST: CardController/Create
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Create(IFormCollection collection)
			{
			try
				{
				return RedirectToAction(nameof(Index));
				}
			catch
				{
				return View();
				}
			}

		// GET: CardController/Edit/5
		public ActionResult Edit(int id)
			{
			return View();
			}

		// POST: CardController/Edit/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Edit(int id, IFormCollection collection)
			{
			try
				{
				return RedirectToAction(nameof(Index));
				}
			catch
				{
				return View();
				}
			}

		// GET: CardController/Delete/5
		public ActionResult Delete(int id)
			{
			return View();
			}

		// POST: CardController/Delete/5
		[HttpPost]
		[ValidateAntiForgeryToken]
		public ActionResult Delete(int id, IFormCollection collection)
			{
			try
				{
				return RedirectToAction(nameof(Index));
				}
			catch
				{
				return View();
				}
			}

		}   // Closing public class CardApiResponse : Controller

	}   // Closing namespace Final___Magix.Controllers
