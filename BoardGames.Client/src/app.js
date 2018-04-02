import { inject } from 'aurelia-framework';
import { PLATFORM } from 'aurelia-pal';

export class App {
  configureRouter(config, router) {
    config.title = 'Board Games Collection';
    config.options.pushState = true;
    
    config.map([
      { route: ['', 'games'], name: 'games', moduleId: PLATFORM.moduleName('./games'), nav: true, title: 'All Games' },
      { route: 'games/:id', name: 'edit-game', moduleId: PLATFORM.moduleName('./edit-game'), nav: false, title: 'Edit Game' },
      { route: 'games/add', name: 'add-game', moduleId: PLATFORM.moduleName('./edit-game'), nav: false, title: 'Add Game' }
    ]);

    this.router = router;
  }
}
