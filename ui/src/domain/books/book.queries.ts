import { gql } from "apollo-angular";

const GET_BOOKS = gql`
  getAllBooks{
    id
    bookName,
    price
  }
`;

export { GET_BOOKS };
