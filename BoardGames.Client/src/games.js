import { ApiService } from './api-service';
import { inject } from 'aurelia-framework';
import environment from './environment';

@inject(ApiService)
export class Games {
    games = [];
    imageRoot = `${environment.apiUrl}images/`;
    page = 1;
    pageSize = 12;

    constructor(api) {
        this.api = api;
    }

    async activate() {
        await this.getPage(this.page);
    }

    async getPage(page) {
        let response = await this.api.getPage(page, this.pageSize);

        this.games = response.items;
        this.totalCount = response.totalCount;
        this.totalPages = response.totalPages;
        this.page = response.page;
        this.pageSize = response.pageSize;
    }
}
