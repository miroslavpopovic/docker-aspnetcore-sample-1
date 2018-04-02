import { ApiService } from './api-service';
import { inject } from 'aurelia-framework';
import { Router } from 'aurelia-router';

@inject(ApiService, Router)
export class EditGame {

    constructor(api, router) {
        this.api = api;
        this.router = router;
    }

    async activate(params) {
        this.isNew = !params.id;
        this.heading = `${this.isNew ? 'Add' : 'Edit'} Game`;

        if (!this.isNew) {
            this.game = await this.api.getById(params.id);
            this.heading = `Edit ${this.game.title}`;
        }
    }

    async save() {
        await this.api.save(this.game);
        this.router.navigateToRoute('games');
    }
}
